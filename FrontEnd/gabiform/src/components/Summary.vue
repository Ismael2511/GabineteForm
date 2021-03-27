<template>
    <div>
        <div class="card mt-5">   
            <div class="card-footer">
                <h5><strong>Datos Personales</strong></h5>
            </div>
            <ul class="list-group list-group-flush">
                <li class="list-group-item"><b>Tipo de Documento:</b> {{mdata.docType}}</li>
                <li class="list-group-item"><b>Número de Documento:</b> {{mdata.idCard}}</li>
                <li class="list-group-item"><b>Nombre:</b> {{mdata.name}}</li>
                <li class="list-group-item"><b>Apellido:</b> {{mdata.lastName}}</li>
                <li class="list-group-item"><b>Correo Electrónico:</b> {{mdata.email}}</li>
                <li class="list-group-item"><b>Dirección:</b> {{mdata.address}}</li>
                <li class="list-group-item"><b>Nacionalidad:</b> {{mdata.nacionality}}</li>
                <li class="list-group-item"><b>Teléfonos:</b> {{mdata.tel1}} / {{mdata.tel2}} // {{mdata.tel3}}</li>
                <li class="list-group-item"><b>Célular:</b> {{mdata.cel}}</li>
                <li class="list-group-item"><b>Lugar de Residencia:</b> {{mdata.residence}}</li>
                <li class="list-group-item"><b>Fecha de Nacimiento:</b> {{mdata.birthDate}}</li>
            </ul>
        </div>
        <div class="card mt-5">   
            <div class="card-footer">
                <h5><strong>Datos del Caso</strong></h5>
            </div>
            <ul class="list-group list-group-flush">
                <li class="list-group-item"><b>Tipo de Programa:</b> {{mdata2.programType}}</li>
                <li class="list-group-item"><b>Número de Documento del Familiar Fallecido:</b> {{mdata2.docDead}}</li>
                <li class="list-group-item"><b>Fecha de Fallecimiento:</b> {{mdata2.dateDead}}</li>
                <li class="list-group-item"><b>Detalles del Caso:</b> {{mdata2.caseDetail}}</li>
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