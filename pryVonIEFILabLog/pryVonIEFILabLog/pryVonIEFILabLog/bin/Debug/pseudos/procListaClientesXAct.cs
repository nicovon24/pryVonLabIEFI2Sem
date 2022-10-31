inicio procedimiento listaDeudores

    string actividad = cbActividad.text
    int idActividad

    grd[0][0]="DNI"
    grd[0][1]="Nombre"
    int fg = 1

    si(actividad!=""){

        leer y abrir add.actividades
        mientras not add.actividades.eof
            si(add.actividades.detalle==actividad)
                idActividad = add.actividades.cod_actividad
            fin si
        fin mientras 
        cerrar add.actividades


        leer y abrir add.clientes
        mientras not add.clientes.eof
            //agrego a la grilla solo los clientes que paguen por esa actividad
            si(add.clientes.ID_actividad==idActividad)
                //---agrego a grilla---
                grd[fg][0]=add.clientes.dni
                grd[fg][1]=add.clientes.nombre
                fg++
            fin si
        fin mientras
        cerrar add.clientes

    }
    sino{
        msg("Eliga una opción, por favor")
    }

fin procedimiento