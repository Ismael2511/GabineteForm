<template>
    <div>
        <div class="card mt-5">   
            <div class="card-footer">
                <h5><strong>Datos Personales</strong></h5>
            </div>
            <ul class="list-group list-group-flush">
                <li class="list-group-item"><b>Tipo de Documento:</b> {{mdata.tipo_documento}}</li>
                <li class="list-group-item"><b>Número de Documento:</b> {{mdata.numero_documento}}</li>
                <li class="list-group-item"><b>Nombre:</b> {{mdata.nombre}}</li>
                <li class="list-group-item"><b>Apellido:</b> {{mdata.apellido}}</li>
                <li class="list-group-item"><b>Correo Electrónico:</b> {{mdata.email}}</li>
                <li class="list-group-item"><b>Dirección:</b> {{mdata.direccion}}</li>
                <li class="list-group-item"><b>Nacionalidad:</b> {{mdata.nacionalidad}}</li>
                <li class="list-group-item"><b>Teléfonos:</b> {{mdata.telefono1}} / {{mdata.telefono2}} // {{mdata.telefono3}}</li>
                <li class="list-group-item"><b>Célular:</b> {{mdata.celular}}</li>
                <li class="list-group-item"><b>Lugar de Residencia:</b> {{mdata.lugar_residencia}}</li>
                <li class="list-group-item"><b>Fecha de Nacimiento:</b> {{mdata.fecha_nacimiento}}</li>
            </ul>
        </div>
        <div class="card mt-5">   
            <div class="card-footer">
                <h5><strong>Datos del Caso</strong></h5>
            </div>
            <ul class="list-group list-group-flush">
                <li class="list-group-item"><b>Tipo de Programa:</b> {{mdata.tipo_programa}}</li>
                <li class="list-group-item"><b>Número de Documento del Familiar Fallecido:</b> {{mdata.num_doc_fallecido}}</li>
                <li class="list-group-item"><b>Nombre del Fallecido:</b> {{mdata.nombre_fallecido}}</li>
                <li class="list-group-item"><b>Fecha de Fallecimiento:</b> {{mdata.fecha_fallecimiento}}</li>
                <li class="list-group-item"><b>Detalles del Caso:</b> {{mdata.detalles_fallecimiento}}</li>
            </ul>
        </div>
    </div>
</template>

<script>
export default({
    props:{
        mdata: Object,
        mdata2: Object
    }
})
</script>