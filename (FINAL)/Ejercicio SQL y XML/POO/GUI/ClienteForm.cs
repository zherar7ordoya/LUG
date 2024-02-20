﻿using BEL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
        private EstadoFormulario estado = EstadoFormulario.Normal;
        public ClienteForm() => InitializeComponent();


        private void ClienteForm_Load(object sender, EventArgs e)
        {
            // Estos métodos aquí (Load) para asegurarse que los controles estén inicializados
            InicializarEventHandlers();

            // Llena el DataGridView principal apelando al CONSULTAR del ABMC
            Consultar(); 
        }


        private void InicializarEventHandlers()
        {
            // Botones
            GuardarButton.Click += BotonGuardar;
            CancelarButton.Click += BotonCancelar;

            // DataGridViews
            ListadoDgv.RowEnter += SincronizarControles;
            ListadoDgv.CellClick += Borrar;

            // Controles de usuario
            NombreControl.TextChanged += CompararDatos;
            ApellidoControl.TextChanged += CompararDatos;
            DniControl.TextChanged += CompararDatos;
            FechaNacimientoDtp.ValueChanged += CompararDatos; // Este fue un agregado (no es UserControl)
            EmailControl.TextChanged += CompararDatos;
        }


        private void ConfigurarFormulario()
        {
            bool nombre = NombreControl.Validar();
            bool apellido = ApellidoControl.Validar();
            bool dni = DniControl.Validar();
            bool email = EmailControl.Validar();

            bool validado = nombre && apellido && dni && email;
            Tool.ConfigurarBotones(this, estado, validado);
        }


        #region ||*----------------------------------------------------> EVENTOS

        //|||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE DATAGRIDVIEW

        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            MostrarDetalles(sender, e);
            MostrarVehiculos(sender, e);
        }


        private void MostrarDetalles(object sender, DataGridViewCellEventArgs e)
        {
            // La siguiente línea nunca falla: sin "delay" alguno
            Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;

            CodigoTextbox.Text = cliente.Codigo.ToString();
            NombreControl.Nombre = cliente.Nombre;
            ApellidoControl.Apellido = cliente.Apellido;
            DniControl.Dni = cliente.DNI.ToString();
            FechaNacimientoDtp.Text = cliente.FechaNacimiento.ToString();
            EmailControl.Email = cliente.Email;
        }


        private void MostrarVehiculos(object sender, DataGridViewCellEventArgs e)
        {
            VehiculosDgv.DataSource = null;

            if (ListadoDgv.CurrentRow != null)
            {
                // La siguiente línea nunca falla: sin "delay" alguno
                Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;

                List<Vehiculo> vehiculos = cliente.VehiculosRentados;
                if (vehiculos == null) return; // Si no tiene vehículos rentados
                VehiculosDgv.DataSource = cliente.VehiculosRentados;
            }
        }

        //|||||||||||||||||||||||||||||||||||||| EVENTOS DE CONTROLES DE USUARIO

        private void CompararDatos(object sender, EventArgs e)
        {
            if (ListadoDgv.CurrentRow != null) // Dato: es null durante el alta
            {
                Cliente cliente = (Cliente)ListadoDgv.SelectedRows[0].DataBoundItem;

                bool modificado = (NombreControl.Nombre != cliente.Nombre) ||
                                  (ApellidoControl.Apellido != cliente.Apellido) ||
                                  (DniControl.Dni != cliente.DNI.ToString()) ||
                                  (FechaNacimientoDtp.Text != cliente.FechaNacimiento.ToShortDateString()) ||
                                  (EmailControl.Email != cliente.Email);
                if (modificado) estado = EstadoFormulario.Modificacion;
                else estado = EstadoFormulario.Normal;
            }
            ConfigurarFormulario(); // Actualiza el estado de los botones
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE BOTONES

        private void BotonGuardar(object sender, EventArgs e)
        {
            if (estado == EstadoFormulario.Normal)
            {
                Tool.LimpiarFormularioCliente(Controls);
                estado = EstadoFormulario.Alta;
                ConfigurarFormulario();
                Tool.MostrarInformacion("Complete los campos y luego pulse Guardar");
            }
            else
            {
                if (estado == EstadoFormulario.Alta) Agregar(this, e);
                else if (estado == EstadoFormulario.Modificacion) Modificar(this, e);
            }
        }


        private void BotonCancelar(object sender, EventArgs e)
        {
            DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea cancelar?");
            if (resultado == DialogResult.Yes)
            {
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }

        #endregion
    }
}