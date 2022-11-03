inicio programa
    inicio procedimiento buscarSaldoCliente

        int dni = int.Parse(txtDNI.text)

        si(dni!=""){
            leer y abrir add.clientes

            mientras not add.clientes.eof y add.clientes.DNI<>dni
                leer add.clientes
            fin mientras

            mientras not add.clientes.eof y add.clientes.DNI==dni
                lblDeuda.Text = add.clientes["Nombre y apellido"] + " tiene $" + add.clientes.deuda + " de deuda"
                leer add.clientes
            fin mientras

            si(add.clientes.eof){
                lblDeuda.Text = "No se ha encontrado a dicho cliente en la base de datos"
            }

            cerrar add.clientes
        }
        sino{
            msg("Tipee el cliente que quiere buscar, por favor.")
        }

    fin procedimiento
fin programa 