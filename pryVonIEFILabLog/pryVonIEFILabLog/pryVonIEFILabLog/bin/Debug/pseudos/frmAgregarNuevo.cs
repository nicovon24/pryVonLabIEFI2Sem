inicio procedimiento agregarNuevo
    //---variables---
    //numerica
    int dni = parseInt(txtDNI.text), edad = parseInt(nudEdad.text),
    idBarrio = parseInt(nudBarrio.text), idSucursal = parseInt(nudSucursal.text), idProfesor = parseInt(nudProfesor.text), idActividad = parseInt(txtActuvudad.text)
    
    //texto
    string nombre = txtNombre.text, char sexo = txtSexo.text, telefono = txtTel.text, email = txtEmail.text

    //banderas
    bool flagEstaCodEnClientes = false

    //variables de id a string, luego almacenamos x ej el nombre del profesor aca
    string barrio, sucursal, profesor, actividad

    //---me fijo si esta el codigo en clientes---
    abrir y leer add.clientes
    mientras not add.clientes.eof y add.clientes.DNI<>dni
        leer add.clientes
    fin mientras
    si add.clientes.eof
        flagEstaCodEnClientes = true
    fin si

    //---programa---
    si(flagEstaCodEnClientes==false)
        
    fin si

    sino
        msg("El DNI ya está en addClientes, intente nuevamente.")
    fin sino
fin procedimiento
