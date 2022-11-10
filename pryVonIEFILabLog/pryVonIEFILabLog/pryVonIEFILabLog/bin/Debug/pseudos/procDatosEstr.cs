inicio programa
    //*variables
    //*===================================================================================================================
    //*funcion obtener datos estratégicos, la reutilizaremos en el resto del programa
    //*usaremos un array para contar x ej cuantos clientes de cada sexo o barrio hay
    inicio procedimiento funcObtDatosEstrategicos(string addGetDetalle, string col_id, string col_cod, string col_detalle) 
    //addGetDetalle es x ej add.barrio
    //col_id es de tabla clientes, col_cod de las otras y sirve para ver el codigo o id de la opc eleg en el combo box
        //*===========================
        //*variables
        int fg = 0
        grd[0][0] = "Datos"
        grd[0][1] = "Clientes" //*dsps cambiamos por el parámetro title

        //*importante-array: tendra todos los códigos de x ej los barrios: 
        array arrCodigos = [] //*almacenará todos los id y luego lo recorreremos para contar los datos en add.clientes de cada elemento del array

        //*==================
        //*cargando el array
        abrir y leer add.clientes
        mientras not add.clientes.eof
            bool flagIsInArr = false
            para(int i = 0; i < arrCodigos.length; i++){ //*busco si el codigo ya está en el array
                si(add.clientes[col_id]==arrCodigos[i]){
                    flagIsInArr = true
                }
            }
            //añado el id
            si(flagIsInArr==false){
                arrDetalles[arrDetalles.length-1] = add.clientes[col_id]
            }
        fin mientras
        cerrar add.clientes


        //*===========================
        //*programa
        para(int iArr = 0; iArr < arrCodigos.Length; iArr++){
            //obteniendo el detalle del id, x ej villa siburu para barrio 5, para agregarlo en grilla dsp
            string detalle 
            abrir addGetDetalle
            mientras not addGetDetalle.eof
                si(addGetDetalle[col_cod]==arrCodigos[iArr]){
                    detalle = addGetDetalle[col_detalle]
                }
            fin mientras
            cerrar addGetDetalle

            //contando los clientes para x ej villa siburu
            int counter = 0
            abrir add.clientes
            mientras not add.clientes.eof
                si(add.clientes[col_id]==arrCodigos[iArr]){
                    counter++
                }
            fin mientras
            cerrar add.clientes
            //agregando valores en grilla, ej: villa siburu, 5 clientes... güemes, 2...
            grd[fg][0] = Detalle
            grd[fg][1] = counter
            counter = 0 //reinicializando contador para x ej prox barrio
            fg++
        }


    fin procedimiento


    //*===================================================================================================================
    procedimiento ejecutarPrograma
        //*según opcion en combo box, ejecuto la función para agregar en grilla los valores
        switch(cbOption.Text){
            case "Barrio"   : funcObtDatosEstrategicos("Barrios", "ID_barrio", "Cod_barrio", "Detalle") ; break;
            case "Actividad": funcObtDatosEstrategicos("Actividad", "ID_actividad", "Cod_actividad", "Detalle") ; break;
            case "Sucursal" : funcObtDatosEstrategicos("Sucursales", "ID_sucursal", "Cod_sucursal", "Detalle") ; break;
            case "Profesor" : funcObtDatosEstrategicos("Profesores", "ID_profesor", "Cod_profesor", "Nombre") ; break;
        }
    fin procedimiento

fin programa