inicio programa

    inicio procedimiento agregarNuevo
        //---variables---
        //numerica
        int dni = parseInt(txtDNI.text)
        int deuda = parseInt(txtDeuda.text)
        //banderas
        bool flagEstaCodEnClientes = false

        //---me fijo si esta el codigo en clientes---
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
    fin procedimiento

fin programa
