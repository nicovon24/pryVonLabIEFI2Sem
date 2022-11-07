inicio programa

    inicio procedimiento agregarNuevo
        //---variables---
        //numerica
        int dni = parseInt(txtDNI.text)
        int deuda = parseInt(txtDeuda.text)

        si(dni.text!="" && deuda.text!="")
            //---busco el dni, si no está muestro msg---
            abrir y leer add.clientes
            mientras not add.clientes.eof y add.clientes.DNI<>dni
                leer add.clientes
            fin mientras
            mientras not add.clientes.eof y add.clientes.DNI==dni
                actualizar add.clientes.deuda = deuda
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
