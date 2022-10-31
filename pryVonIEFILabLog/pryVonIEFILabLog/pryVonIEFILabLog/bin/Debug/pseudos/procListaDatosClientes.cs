inicio procedimiento listaDatosClientes

    grd[0][0]="DNI"
    grd[0][1]="Nombre"
    grd[0][2]="Deuda"
    grd[0][3]="Barrio"
    grd[0][4]="Sucursal"
    grd[0][5]="Actividad"

    int fg = 1

    leer y abrir add.clientes

    mientras not add.clientes.eof

        //---inicializo variables que paso de id a detalle---
        string strBarrio, strSucursal, strActividad


        //---busco detalles de ids---
        //barrios
        abrir y leer add.barrios
        mientras not add.barrios.eof y add.barrios.cod_barrio<>add.clientes.ID_barrio
            leer add.barrios
        fin mientras

        mientras not add.barrios.eof y add.barrios.cod_barrio==add.clientes.ID_barrio
            strBarrio = add.barrios.detalle
            leer add.barrios
        fin mientras
        cerrar add.barrios


        //sucursales
        abrir y leer add.sucursales
        mientras not add.sucursales.eof y add.sucursales.cod_sucursal<>add.clientes.ID_Sucursal
            leer add.sucursales
        fin mientras

        mientras not add.sucursales.eof y add.sucursales.cod_sucursal==add.clientes.ID_Sucursal
            strSucursal = add.sucursales.detalle
            leer add.sucursales
        fin mientras
        cerrar add.sucursales


        //actividades
        abrir y leer add.actividades
        mientras not add.actividades.eof y add.actividades.cod_actividad<>add.clientes.ID_Actividad
            leer add.actividades
        fin mientras

        mientras not add.actividades.eof y add.actividades.cod_actividad==add.clientes.ID_Actividad
            strActividad = add.actividades.detalle
            leer add.actividades
        fin mientras
        cerrar add.actividades


        //---agrego a grilla---
        grd[fg][0]=add.clientes.dni
        grd[fg][1]=add.clientes.nombre
        grd[fg][2]=add.clientes.deuda
        grd[fg][3]=strBarrio
        grd[fg][4]=strSucursal
        grd[fg][5]=strActividad

        fg++

    fin mientras

    cerrar add.clientes

fin procedimiento