<template>
    <div class="container mt-5" >
        <div class="card col-lg-10 p-5">
            <h5><strong>Campos Obligatorios <span class="text-danger">*</span></strong></h5>
            
            <form class="row g-3" v-if="initial">
                <hr>
                <h3><span class="badge bg-secondary">Datos Personales</span></h3>
                <div class="col-md-6">
                    <label for="docType" class="form-label">Tipo de Documento <span class="text-danger">*</span></label>
                    <select id="docType" class="form-select">
                        <option>Cédula</option>
                        <option>Pasaporte</option>
                    </select>
                </div>
                <div class="col-md-6" >
                        <label for="idCard" class="form-label">Número de Documento <span class="text-danger">*</span></label>
                        <input type="number" class="form-control" id="idCard" placeholder="000-0000000-0">
                    </div>
                    <div class="col-md-6" >
                        <label for="name" class="form-label">Nombre <span class="text-danger">*</span></label>
                        <input type="text" class="form-control" id="name">
                    </div>
                    
                 <div class="col-md-6">
                    <label for="name" class="form-label">Apellido <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="lastName">
                </div>
               
               <div class="col-md-6">
                    <label for="email" class="form-label">Correo Electrónico <span class="text-danger">*</span></label>
                    <input type="email" class="form-control" placeholder="ejemplo@ejemplo.com" id="email">
                </div>

                <div class="col-md-6">
                    <label for="address" class="form-label">Dirección <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="address">
                </div>
                
                <div class="col-md-6">
                    <label for="nacionality" class="form-label">Nacionalidad <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="nacionality">
                </div>
                
                <div class="col-md-6">
                    <label for="tel1" class="form-label">Teléfono 1 <span class="text-danger">*</span></label>
                    <input type="number" class="form-control" id="tel1">
                </div>
                <div class="col-md-6">
                    <label for="tel2" class="form-label">Teléfono 2</label>
                    <input type="number" class="form-control" id="tel2">
                </div>
                <div class="col-md-6">
                    <label for="tel3" class="form-label">Teléfono 3</label>
                    <input type="number" class="form-control" id="tel3">
                </div>
                <div class="col-md-6">
                    <label for="tel3" class="form-label">Celular <span class="text-danger">*</span></label>
                    <input type="number" class="form-control" id="tel3">
                </div>
                <div class="col-md-6">
                    <label for="residence" class="form-label">Lugar de Residencia <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="inputCity">
                </div>
                <div class="col-md-6">
                    <label for="birthDate" class="form-label">Fecha de Nacimiento <span class="text-danger">*</span></label>
                    <input type="date" class="form-control" id="birthDate">
                </div>
                
            </form>
            <!--  -->
            <form class="row g-3" v-if="!initial">
                <hr>
                <h3><span class="badge bg-secondary">Datos del Caso</span></h3>
                <div class="col-md-6">
                    <label for="programType" class="form-label">Tipo de Programa <span class="text-danger">*</span></label>
                    <select id="programType" class="form-select">
                        <option>Familia Acompañada</option>
                        <option>Otros</option>
                    </select>
                </div>
                <div class="col-md-6" >
                    <label for="nameDead" class="form-label">Nombre del Familiar Fallecido<span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="nameDead">
                </div>
                <div class="col-md-6">
                    <label for="docDead" class="form-label">Número de Documento del Familiar Fallecido <span class="text-danger">*</span></label>
                    <input type="number" placeholder="000-0000000-0" class="form-control" id="docDead">
                </div>
                <div class="col-md-6">
                    <label for="docDead" class="form-label">Fecha de Fallecimiento <span class="text-danger">*</span></label>
                    <input type="date" class="form-control" id="dateDead">
                </div>
                <div class="col-lg" >
                    <label for="caseDetail">Detalles del Caso (Ser Específicos) <span class="text-danger">*</span></label>
                    <textarea class="form-control" id="caseDetail" style="height: 100px"></textarea>
                </div>
                
            </form> 
                <div class="col mt-4">
                        <button 
                            type="submit" 
                            @click.prevent="initial = !initial" 
                            class="btn btn-secondary me-2" 
                            v-if="initial == false"  
                        >Atrás
                        </button>
                        <button 
                            type="submit" 
                            @click.prevent="initial = !initial" 
                            class="btn btn-primary" 
                            v-text="btnText" 
                        />
                </div>
            </div>   
             
    </div>
</template>

<script>

export default ({
    data(){
        return{
            initial: true,
            btnText: 'Siguiente'
        }
    }
})
</script>
