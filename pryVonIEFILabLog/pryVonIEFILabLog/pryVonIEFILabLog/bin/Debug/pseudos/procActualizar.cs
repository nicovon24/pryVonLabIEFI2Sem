inicio programa

    inicio procedimiento agregarNuevo
        //=========================================================================
        //---variables---
        //numerica
        int dni = parseInt(txtDNI.text)
        string strBarrio = cbBarrio.text, strSucursal = cbSucursal.text, strProfesor = cbProfesor.text, strActividad = cbActividad.text
        int idBarrio, idSucursal, idProfesor, idActividad

        //=========================================================================
        //programa
        si(dni.text!="" && deuda.text!="")
            //---busco el dni, si no está muestro msg---
            abrir y leer add.clientes
            mientras not add.clientes.eof y add.clientes.DNI<>dni
                leer add.clientes
            fin mientras
            mientras not add.clientes.eof y add.clientes.DNI==dni
                //--abro y uso los demás archivos para buscar el id de barrio, sucursal, profesor y actividad
                //================
                //barrios
                abrir y leer add.barrios
                mientras not add.barrios.eof y add.barrios.detalle<>strBarrio
                    si(add.barrios.detalle==strBarrio)
                        idBarrio = int.Parse(add.barrios.cod_barrio)
                    fin si
                    leer add.barrios
                fin mientras
                cerrar add.barrios

                //================
                //sucursales
                abrir y leer add.sucursales
                mientras not add.sucursales.eof y add.sucursales.detalle<>strSucursal
                    si(add.sucursales.detalle==strSucursal)
                        idSucursal = int.Parse(add.sucursales.cod_sucursal)
                    fin si
                    leer add.sucursales
                fin mientras
                cerrar add.sucursales

                //================
                //profesores
                abrir y leer add.profesores
                mientras not add.profesores.eof y add.profesores.nombre<>strProfesor
                    si(add.profesores.nombre==strProfesor)
                        idProfesor = int.Parse(add.profesores.cod_profesor)
                    fin si
                    leer add.profesores
                fin mientras
                cerrar add.profesores

                //================
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
                //sentencia
                actualizar{ 
                    add.clientes.deuda = parseInt(txtDeuda.text)
                    add.clientes.ID_barrio = idBarrio
                    add.clientes.ID_actividad = idActividad
                    add.clientes.ID_profesor = idProfesor
                    add.clientes.ID_sucursal = idSucursal
                }
            fin si
            si add.clientes.eof{
                msg("El DNI no está en addClientes, intente nuevamente.")
            }
            cerrar add.clientes
        fin si
        sino
            msg("Tipee el cliente que quiere buscar, por favor.")
        fin sino
    fin procedimiento

fin programa
