USE Prinzo

GO


CREATE TABLE
  Agencia (agencia_id INT PRIMARY KEY);


CREATE TABLE
  Vehiculo (
    vehiculo_id INT PRIMARY KEY,
    marca VARCHAR(50),
    modelo VARCHAR(50),
    patente VARCHAR(20)
  );


CREATE TABLE
  Cliente (
    cliente_id INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni VARCHAR(20),
    fechaNacimiento DATE,
    correoElectronico VARCHAR(100)
  );



CREATE TABLE
  Alquiler (alquiler_id INT PRIMARY KEY, dias INT, importe FLOAT);



ALTER TABLE
  Vehiculo
ADD
  agencia_id INT,
  FOREIGN KEY (agencia_id) REFERENCES Agencia(agencia_id);


ALTER TABLE
  Cliente
ADD
  agencia_id INT,
  FOREIGN KEY (agencia_id) REFERENCES Agencia(agencia_id);


ALTER TABLE
  Alquiler
ADD
  vehiculo_id INT,
  FOREIGN KEY (vehiculo_id) REFERENCES Vehiculo(vehiculo_id);


ALTER TABLE
  Alquiler
ADD
  cliente_id INT,
  FOREIGN KEY (cliente_id) REFERENCES Cliente(cliente_id);

  