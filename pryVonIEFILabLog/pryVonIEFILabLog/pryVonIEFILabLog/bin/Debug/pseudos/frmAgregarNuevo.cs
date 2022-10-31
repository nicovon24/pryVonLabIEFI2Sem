inicio procedimiento agregarNuevo
    //---variables---
    //numerica
    int dni = parseInt(txtDNI.text), deuda = parseInt(nudDeuda.text)
    
    //texto
    string nombre = txtNombre.text, char sexo = txtSexo.text, telefono = txtTel.text, email = txtEmail.text
    string strBarrio = cbBarrio.text, strSucursal = cbSucursal.text, strProfesor = cbProfesor.text, strActividad = cbActividad.text

    //char
    char edad = cbEdad.text

    //banderas
    bool flagEstaCodEnClientes = false

    //variables de string a id, luego almacenamos x ej el nombre del profesor aca
    int idBarrio, idSucursal, idProfesor, idActividad

    //---me fijo si esta el codigo en clientes---
    abrir y leer add.clientes
    mientras not add.clientes.eof y add.clientes.DNI<>dni
        leer add.clientes
    fin mientras
    si add.clientes.eof
        flagEstaCodEnClientes = true
    fin si
    cerrar add.clientes

    //---programa---
    si(flagEstaCodEnClientes==false){
        //we check if all inputs data are completed
        si (cbActividad.Text != "" && cbBarrio.Text != "" && cbProfesor.Text != "" && cbSexo.Text != "" && cbSucursal.Text != ""
            && txtDNI.Text != "" && txtEmail.Text != "" && txtNombre.Text != "" && txtTel.Text != "" && nudDeuda.Value != 0)
        {
            si (txtEmail.Text.Contains("@gmail.com") == true || txtEmail.Text.Contains("@outlook.com")==true || txtEmail.Text.Contains("@hotmail.com") == true)
            {
                //--abro y uso los demás archivos para buscar el id de barrio, sucursal, profesor y actividad
                //barrios
                abrir y leer add.barrios
                mientras not add.barrios.eof y add.barrios.detalle<>barrio
                    leer add.barrios
                fin mientras

                mientras not add.barrios.eof y add.barrios.detalle==barrio
                    idBarrio = int.Parse(add.barrios.cod_barrio)
                    leer add.barrios
                fin mientras
                cerrar add.barrios



                //sucursales
                abrir y leer add.sucursales
                mientras not add.sucursales.eof y add.sucursales.detalle<>sucursal
                    leer add.sucursales
                fin mientras

                mientras not add.sucursales.eof y add.sucursales.detalle==sucursal
                    idSucursal = int.Parse(add.sucursales.cod_sucursal)
                    leer add.sucursales
                fin mientras
                cerrar add.sucursales



                //profesores
                abrir y leer add.profesores
                mientras not add.profesores.eof y add.profesores.nombre<>strProfesor
                    leer add.profesores
                fin mientras

                mientras not add.profesores.eof y add.profesores.nombre==strProfesor
                    idProfesor = int.Parse(add.profesores.cod_barrio)
                    leer add.profesores
                fin mientras
                cerrar add.profesores



                //actividades
                abrir y leer add.actividades
                mientras not add.actividades.eof y add.actividades.detalle<>strActividad
                    leer add.actividades
                fin mientras

                mientras not add.actividades.eof y add.actividades.detalle==strActividad
                    idActividad = int.Parse(add.actividades.cod_barrio)
                    leer add.actividades
                fin mientras
                cerrar add.actividades
                

                //---connecting to the data base clientes and adding data into it---
                string urlDB = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";

                sqlTables = "Insert into Clientes (DNI, [Nombre y apellido], Sexo, Deuda, ID_barrio, ID_sucursal, ID_profesor, ID_actividad, Teléfono, Email) " +
                
                sqlValues = dni + ", '" + nombre + "', '" + sexo + "', " + deuda + ", " + idBarrio + ", " + idSucursal + ", " + idProfesor + ", "
                + idActividad + ", '" + telefono + "', '" + email + "'"

                OleDbConnection dbConnection = new OleDbConnection(urlDB);
                dbConnection.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = dbConnection;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Clientes (" + sqlTables + ") VALUES(" + sqlValues + ")";
                comando.ExecuteNonQuery();
                MessageBox.Show("Dato cargado");
                dbConnection.Close();
            }
        }
    }

    else{
        msg("El DNI ya está en addClientes, intente nuevamente.")
    }
fin procedimiento
