<template>
    <div class="container mt-5" >
        <div class="card col-lg-10 p-5">
            <h5><strong>Campos Obligatorios <span class="text-danger">*</span></strong></h5>
            
            <form class="row g-3" v-if="initial">
                <hr>
                <div class="alert alert-danger" v-if="errors.size > 0" role="alert">
                    <li>Todos Campos deben de ser llenados Correctamente</li>
                </div>
                <h3><span class="badge bg-secondary">Datos Personales</span></h3>
                <div class="col-md-6">
                    <label for="docType" class="form-label">Tipo de Documento <span class="text-danger">*</span></label>
                    <select id="docType" class="form-select" v-model.lazy.trim="docType">
                        <option>Cédula</option>
                        <option>Pasaporte</option>
                    </select>
                </div>
                <div class="col-md-6" >
                        <label for="idCard" class="form-label">Número de Documento <span class="text-danger">*</span></label>
                        <input type="number" class="form-control" id="idCard" placeholder="000-0000000-0" v-model.lazy.number="idCard">
                        <p class="text-danger">{{errors.get("idCard")}}</p>
                    </div>
                    <div class="col-md-6" >
                        <label for="name" class="form-label">Nombre <span class="text-danger">*</span></label>
                        <input type="text" class="form-control" id="name" v-model.trim="name">
                        <p class="text-danger">{{errors.get("name")}}</p>
                    </div>
                    
                 <div class="col-md-6">
                    <label for="lastName" class="form-label">Apellido <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="lastName" v-model.lazy.trim="lastName">
                        <p class="text-danger">{{errors.get("lastName")}}</p>
                </div>
               
               <div class="col-md-6">
                    <label for="email" class="form-label">Correo Electrónico <span class="text-danger">*</span></label>
                    <input type="email" class="form-control" placeholder="ejemplo@ejemplo.com" id="email" v-model.lazy.trim="email">
                    <p class="text-danger">{{errors.get("email")}}</p>
                </div>

                <div class="col-md-6">
                    <label for="address" class="form-label">Dirección <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="address" v-model.lazy.trim="address">
                    <p class="text-danger">{{errors.get("address")}}</p>
                </div>
                
                <div class="col-md-6">
                    <label for="nacionality" class="form-label">Nacionalidad <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="nacionality" v-model.lazy.trim="nacionality">
                    <p class="text-danger">{{errors.get("nacionality")}}</p>
                </div>
                
                <div class="col-md-6">
                    <label for="tel1" class="form-label">Teléfono 1</label>
                    <input type="number" class="form-control" id="tel1" v-model.lazy.number="tel1">
                    <p class="text-danger">{{errors.get("tel1")}}</p>
                </div>
                <div class="col-md-6">
                    <label for="tel2" class="form-label">Teléfono 2</label>
                    <input type="number" class="form-control" id="tel2" v-model.lazy.number="tel2">
                    <p class="text-danger">{{errors.get("tel2")}}</p>
                </div>
                <div class="col-md-6">
                    <label for="tel3" class="form-label">Teléfono 3</label>
                    <input type="number" class="form-control" id="tel3" v-model.lazy.number="tel3">
                    <p class="text-danger">{{errors.get("tel3")}}</p>
                </div>
                <div class="col-md-6">
                    <label for="cel" class="form-label">Celular <span class="text-danger">*</span></label>
                    <input type="number" class="form-control" id="cel" v-model.lazy.number="cel">
                    <p class="text-danger">{{errors.get("cel")}}</p>
                </div>
                <div class="col-md-6">
                    <label for="residence" class="form-label">Lugar de Residencia <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="inputCity" v-model.lazy.trim="residence">
                    <p class="text-danger">{{errors.get("residence")}}</p>
                </div>
                <div class="col-md-6">
                    <label for="birthDate" class="form-label">Fecha de Nacimiento <span class="text-danger">*</span></label>
                    <input type="date" class="form-control" id="birthDate" v-model.lazy="birthDate">
                    <p class="text-danger">{{errors.get("birthDate")}}</p>
                </div>
                
            </form>
            <!--  -->
            <form class="row g-3" v-if="!initial">
                <div class="alert alert-danger" role="alert">
                    <p v-for="(err,i) in errors" :key="i" v-text="err" />
                </div>
                <hr>
                <h3><span class="badge bg-secondary">Datos del Caso</span></h3>
                <div class="col-md-6">
                    <label for="programType" class="form-label">Tipo de Programa <span class="text-danger">*</span></label>
                    <select id="programType" class="form-select" v-model.lazy="programType">
                        <option>Familia Acompañada</option>
                        <option>Otros</option>
                    </select>
                </div>
                <div class="col-md-6" >
                    <label for="nameDead" class="form-label">Nombre del Familiar Fallecido<span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="nameDead" v-model.lazy.trim="nameDead">
                    <p class="text-danger">{{errors.get("nameDead")}}</p>
                </div>
                <div class="col-md-6">
                    <label for="docDead" class="form-label">Número de Documento del Familiar Fallecido <span class="text-danger">*</span></label>
                    <input type="number" placeholder="000-0000000-0" class="form-control" id="docDead" v-model.lazy.number="docDead">
                    <p class="text-danger">{{errors.get("docDead")}}</p>
                </div>
                <div class="col-md-6">
                    <label for="docDead" class="form-label">Fecha de Fallecimiento <span class="text-danger">*</span></label>
                    <input type="date" class="form-control" id="dateDead" v-model.lazy="dateDead">
                    <p class="text-danger">{{errors.get("dateDead")}}</p>
                </div>
                <div class="col-lg" >
                    <label for="caseDetail">Detalles del Caso (Ser Específicos) <span class="text-danger">*</span></label>
                    <textarea class="form-control" id="caseDetail" style="height: 100px" v-model.lazy.trim="caseDetail"></textarea>
                    <p class="text-danger">{{errors.get("caseDetail")}}</p>
                </div>
                
            </form> 
                <div class="col-md mt-2">
                    <div class="btn-group" role="group" aria-label="Basic radio toggle button group">
                        <input type="radio" @click="as = true" class="btn-check" name="btnradio" id="btnradio1" autocomplete="off" checked>
                        <label class="btn btn-outline-primary" for="btnradio1">Ver Resumen</label>                        
                    </div>
                </div>
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
                            @click.prevent="submitForm" 
                            class="btn btn-primary" 
                        >Siguiente</button>
                </div>
            </div>   
    </div>
</template>

<script>
export default ({
    data(){
        return{
            initial: true,
            btnText: 'Siguiente',
            errors: new Map(),
            docType:'',
            idCard:'',
            name:'',
            lastName:'',
            email:'',
            address:'',
            nacionality:'',
            tel1:'',
            tel2:'',
            tel3:'',
            cel:'',
            residence:'',
            birthDate:'',
            mdata2: {
                programType:'',
                nameDead:'',
                docDead:'',
                dateDead:'',
                caseDetail:''
            }
        }
    },
    watch:{
        
    },
    methods:{
        inpValidation(){
            this.name === "" ? this.errors.set("name",'El campo debe de ser llenado') : this.errors.delete("name"); 
            this.lastName === "" ? this.errors.set("lastName",'El campo debe de ser llenado') : this.errors.delete("lastName"); 
            this.email === "" || !this.email.includes("@") && !this.email.includes(".") ?
            this.errors.set("email",'El campo debe de contener @ y .') : this.errors.delete("email"); 
            this.address === "" ? this.errors.set("address",'El campo debe de ser llenado') : this.errors.delete("address"); 
            this.nacionality === "" ? this.errors.set("nacionality",'El campo debe de ser llenado') : this.errors.delete("nacionality"); 
            this.tel1 === "" ? this.errors.set("tel1",'El campo debe de ser llenado') : this.errors.delete("tel1"); 
            this.cel === "" ? this.errors.set("cel",'El campo debe de ser llenado') : this.errors.delete("cel"); 
            this.lastName === "" ? this.errors.set("lastName",'El campo debe de ser llenado') : this.errors.delete("lastName"); 
            this.birthDate === "" ? this.errors.set("birthDate",'El campo debe de ser llenado') : this.errors.delete("birthDate"); 
            this.residence === "" ? this.errors.set("residence",'El campo debe de ser llenado') : this.errors.delete("residence"); 
        },
        submitForm(){
            this.inpValidation();
            
            //Guard
            if(this.errors.size > 0) return;

            this.initial = !this.initial;
            console.log('object')
        }
    }
})
</script>
