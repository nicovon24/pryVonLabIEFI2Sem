inicio programa
    inicio procedimiento agregarNuevo
        //=========================================================================
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
        si add.clientes.eof y add.clientes.DNI==dni
            flagEstaCodEnClientes = true
        fin si
        cerrar add.clientes

        //=========================================================================
        //---programa---
        si(flagEstaCodEnClientes==false){
            //we check if all inputs data are completed
            si (strActividad != "" && strBarrio != "" && strProfesor != "" && sexo != "" && strSucursal != ""
                && dni != "0" && email != "" && nombre != "" && telefono != "" && nudDeuda.Value != 0)
            {
                si (email.Contains("@gmail.com") == true || email.Contains("@outlook.com")==true || email.Contains("@hotmail.com") == true)
                {
                    //================
                    //--abro y uso los demás archivos para buscar el id de barrio, sucursal, profesor y actividad
                    //barrios
                    abrir y leer add.barrios
                    mientras not add.barrios.eof y add.barrios.detalle<>strBarrio
                        si(add.barrios.detalle==strBarrio)
                            idBarrio = int.Parse(add.barrios.cod_barrio)
                        fin si
                        leer add.barrios
                    fin mientras
                    cerrar add.barrios


                    //sucursales
                    abrir y leer add.sucursales
                    mientras not add.sucursales.eof y add.sucursales.detalle<>strSucursal
                        si(add.sucursales.detalle==strSucursal)
                            idSucursal = int.Parse(add.sucursales.cod_sucursal)
                        fin si
                        leer add.sucursales
                    fin mientras
                    cerrar add.sucursales


                    //profesores
                    abrir y leer add.profesores
                    mientras not add.profesores.eof y add.profesores.nombre<>strProfesor
                        si(add.profesores.nombre==strProfesor)
                            idProfesor = int.Parse(add.profesores.cod_profesor)
                        fin si
                        leer add.profesores
                    fin mientras
                    cerrar add.profesores


                    //actividades
                    abrir y leer add.actividades
                    mientras not add.actividades.eof y add.actividades.detalle<>strActividad
                        si(add.actividades.detalle==strActividad)
                            idActividad = int.Parse(add.actividades.cod_actividad)
                        fin si
                        leer add.actividades
                    fin mientras
                    cerrar add.actividades


                    //================
                    //agregar
                    agregar en Clientes{
                        add.clientes.dni = dni,
                        add.clientes.nombre = nombre,
                        add.clientes.sexo = sexo,
                        add.clientes.deuda = deuda,
                        add.clientes["ID_barrio"] = idBarrio,
                        add.clientes["ID_sucursal"] = id_sucursal,
                        add.clientes["ID_profesor"] = idProfesor,
                        add.clientes["ID_actividad"] = idActividad,
                        add.clientes["ID_telefono"] = idTelefono,
                        add.clientes["ID_email"] = idEmail
                    }

                    ejecutar agregar
                    
                    MessageBox.Show("Dato cargado");
                }
            }
        }

        else{
            msg("El DNI ya está en addClientes, intente nuevamente.")
        }
    fin procedimiento


fin programa