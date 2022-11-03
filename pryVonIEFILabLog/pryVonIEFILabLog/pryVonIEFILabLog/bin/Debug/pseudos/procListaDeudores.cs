inicio programa

    inicio procedimiento listaDeudores

        grd[0][0]="DNI"
        grd[0][1]="Nombre"
        grd[0][2]="Deuda"

        int fg = 1

        leer y abrir add.clientes

        mientras not add.clientes.eof

            si(add.clientes.deuda>0)
                //---agrego a grilla---
                grd[fg][0]=add.clientes.dni
                grd[fg][1]=add.clientes.nombre
                grd[fg][2]=add.clientes.deuda
                fg++
                
            fin si

        fin mientras

        cerrar add.clientes

    fin procedimiento

fin programa