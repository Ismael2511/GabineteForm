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
                    <select id="docType" class="form-select" v-model.lazy.trim="mdata.tipo_documento">
                        <option>Cédula</option>
                        <option>Pasaporte</option>
                    </select>
                </div>
                <div class="col-md-6" >
                        <label for="idCard" class="form-label">Número de Documento <span class="text-danger">*</span></label>
                        <input type="number" class="form-control" id="idCard" placeholder="000-0000000-0" v-model.number="mdata.numero_documento">
                        <!-- <p class="text-danger">{{errors.get("idCard")}}</p> -->
                    </div>
                    <div class="col-md-6" >
                        <label for="name" class="form-label">Nombre <span class="text-danger">*</span></label>
                        <input type="text" class="form-control" id="name" v-model.trim="mdata.nombre">
                        <!-- <p class="text-danger">{{errors.get("name")}}</p> -->
                    </div>
                    
                 <div class="col-md-6">
                    <label for="lastName" class="form-label">Apellido <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="lastName" v-model.trim="mdata.apellido">
                        <!-- <p class="text-danger">{{errors.get("lastName")}}</p> -->
                </div>
               
               <div class="col-md-6">
                    <label for="email" class="form-label">Correo Electrónico <span class="text-danger">*</span></label>
                    <input type="email" class="form-control" placeholder="ejemplo@ejemplo.com" id="email" v-model.trim="mdata.email">
                    <p class="text-danger">{{errors.get("email")}}</p>
                </div>

                <div class="col-md-6">
                    <label for="address" class="form-label">Dirección <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="address" v-model.trim="mdata.direccion">
                    <!-- <p class="text-danger">{{errors.get("address")}}</p> -->
                </div>
                
                <div class="col-md-6">
                    <label for="nacionality" class="form-label">Nacionalidad <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="nacionality" v-model.trim="mdata.nacionalidad">
                    <!-- <p class="text-danger">{{errors.get("nacionality")}}</p> -->
                </div>
                
                <div class="col-md-6">
                    <label for="tel1" class="form-label">Teléfono 1 <span class="text-danger">*</span></label>
                    <input type="number" class="form-control" id="tel1" v-model.number="mdata.telefono1">
                    <!-- <p class="text-danger">{{errors.get("tel1")}}</p> -->
                </div>
                <div class="col-md-6">
                    <label for="tel2" class="form-label">Teléfono 2</label>
                    <input type="number" class="form-control" id="tel2" v-model.number="mdata.telefono2">
                    <!-- <p class="text-danger">{{errors.get("tel2")}}</p> -->
                </div>
                <div class="col-md-6">
                    <label for="tel3" class="form-label">Teléfono 3</label>
                    <input type="number" class="form-control" id="tel3" v-model.number="mdata.telefono3">
                    <!-- <p class="text-danger">{{errors.get("tel3")}}</p> -->
                </div>
                <div class="col-md-6">
                    <label for="cel" class="form-label">Célular <span class="text-danger">*</span></label>
                    <input type="number" class="form-control" id="cel" v-model.number="mdata.celular">
                    <!-- <p class="text-danger">{{errors.get("cel")}}</p> -->
                </div>
                <div class="col-md-6">
                    <label for="residence" class="form-label">Lugar de Residencia <span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="residence" v-model.trim="mdata.lugar_residencia">
                    <!-- <p class="text-danger">{{errors.get("residence")}}</p> -->
                </div>
                <div class="col-md-6">
                    <label for="birthDate" class="form-label">Fecha de Nacimiento <span class="text-danger">*</span></label>
                    <input type="date" class="form-control" id="birthDate" v-model="mdata.fecha_nacimiento">
                    <!-- <p class="text-danger">{{errors.get("birthDate")}}</p> -->
                </div>
                
            </form>
            <!--  -->
            <form class="row g-3" v-if="!initial">
                <hr>
                <div class="alert alert-danger" v-if="err.length > 0" role="alert">
                    <li v-for="(el,i) in err" :key="i">{{el}}</li>
                </div>
                <h3><span class="badge bg-secondary">Datos del Caso</span></h3>
                <div class="col-md-6">
                    <label for="programType" class="form-label">Tipo de Programa <span class="text-danger">*</span></label>
                    <select id="programType" class="form-select" v-model.lazy="mdata.tipo_programa">
                        <option>Familia Acompañada</option>
                        <option>Otros</option>
                    </select>
                </div>
                <div class="col-md-6" >
                    <label for="nameDead" class="form-label">Nombre del Familiar Fallecido<span class="text-danger">*</span></label>
                    <input type="text" class="form-control" id="nameDead" v-model.lazy.trim="mdata.nombre_fallecido">
                    <!-- <p class="text-danger">{{errors.get("nameDead")}}</p> -->
                </div>
                <div class="col-md-6">
                    <label for="docDead" class="form-label">Número de Documento del Familiar Fallecido <span class="text-danger">*</span></label>
                    <input type="number" placeholder="000-0000000-0" class="form-control" id="docDead" v-model.lazy.number="mdata.num_doc_fallecido">
                    <!-- <p class="text-danger">{{errors.get("docDead")}}</p> -->
                </div>
                <div class="col-md-6">
                    <label for="dateDead" class="form-label">Fecha de Fallecimiento <span class="text-danger">*</span></label>
                    <input type="date" class="form-control" id="dateDead" v-model.lazy="mdata.fecha_fallecimiento">
                    <!-- <p class="text-danger">{{errors.get("dateDead")}}</p> -->
                </div>
                <div class="col-lg" >
                    <label for="caseDetail">Detalles del Caso (Ser Específicos) <span class="text-danger">*</span></label>
                    <textarea class="form-control" id="caseDetail" style="height: 100px" v-model.trim="mdata.detalles_fallecimiento"></textarea>
                    <p class="text-secondary">{{mdata.detalles_fallecimiento.length}}/150</p>
                    <!-- <p class="text-danger">{{errors.get("caseDetail")}}</p>   -->
                </div>
                
            </form> 
               <div class="col-md mt-2">
                        <button 
                            type="submit" 
                            @click.prevent="showSummary" 
                            class="btn btn-outline-info me-2" 
                            v-if="initial == false"  
                        >Ver Resumen
                        </button>
                </div>
                <div class="spinner-border text-primary mt-4" v-if="spinner" role="status">
                </div>
                <div class="col mt-4">
                        <button 
                            type="submit" 
                            @click.prevent="initial = true" 
                            class="btn btn-secondary me-2" 
                            v-if="initial == false"  
                        >Atrás
                        </button>
                        <button 
                            type="submit" 
                            @click.prevent="changeView" 
                            class="btn btn-primary" 
                            v-if="initial == true"
                        >Siguiente</button>
                        <button 
                            type="submit" 
                            @click.prevent="onSubmit" 
                            :disabled="disableButton"
                            class="btn btn-primary" 
                            v-if="initial == false"
                        >Enviar</button>
                </div>
                 <div class="mt-2">
                     <component :is="summary" :mdata="mdata" v-if="!initial"/> 
                 </div>
            </div>   
    </div>
</template>

<script>
import {BaseView} from '../common/BaseView'
import Summary from './Summary'

export default ({
    components: { Summary },
    mixins: [BaseView],
    data(){
        return{
            initial: true,
            errors: new Map(),
            err:[],
            summary: null,        
            mdata: {
                tipo_documento:'Cédula',
                numero_documento:'',
                nombre:'',
                apellido:'',
                email:'',
                direccion:'',
                nacionalidad:'',
                telefono1:'',
                telefono2:'',
                telefono3:'',
                celular:'',
                lugar_residencia:'',
                fecha_nacimiento:'',

                tipo_programa:'Familia Acompañada',
                nombre_fallecido:'',
                num_doc_fallecido:'',
                fecha_fallecimiento:'',
                detalles_fallecimiento:''
            },
            methodSave: 'Gabinete/savePersona'
        }
    },
    created(){
        this.$on('onSubmit', (data) => {
            if(data.successfull){
                this.$emit('finished', true);
                return;
            }
            this.err = []
            let errorApi = data.messages;
            for(const [i,el] of errorApi.entries()) {
                console.log(i)
                this.err.push(el)
            }
        });
    },
    methods:{
        inpValidation(){
            this.errors.clear();
            if(this.mdata.nombre === ""){
                document.querySelector('#name').style.border = '1px solid red'
                this.errors.set("name",'El campo debe de ser llenado');
                console.log('as')
            }else{
                console.log('else')

                document.querySelector('#name').style.border = '1px solid green'
                this.errors.delete("name")
            }
            if(this.mdata.apellido === ""){
                document.querySelector('#lastName').style.border = '1px solid red'
                this.errors.set("lastName",'El campo debe de ser llenado');
            }else{
                document.querySelector('#lastName').style.border = '1px solid green'
                this.errors.delete("lastName")
            }
            if(this.mdata.numero_documento === ""){
                document.querySelector('#idCard').style.border = '1px solid red'
                this.errors.set("idCard",'El campo debe de contener 11 digitos');
            }else{
                document.querySelector('#idCard').style.border = '1px solid green'
                this.errors.delete("idCard")
            }
            if(this.mdata.email === "" || !this.mdata.email.includes("@") && !this.mdata.email.includes(".")){
                document.querySelector('#email').style.border = '1px solid red'
                this.errors.set("email",'El campo debe de contener @ y .') ;
            }else{
                document.querySelector('#email').style.border = '1px solid green'
                this.errors.delete("email")
            }
            if(this.mdata.direccion === ""){
                document.querySelector('#address').style.border = '1px solid red'
                this.errors.set("address",'El campo debe de ser llenado');
            }else{
                document.querySelector('#address').style.border = '1px solid green'
                this.errors.delete("address")
            }
            if(this.mdata.nacionalidad === ""){
                document.querySelector('#nacionality').style.border = '1px solid red'
                this.errors.set("nacionality",'El campo debe de ser llenado');
            }else{
                document.querySelector('#nacionality').style.border = '1px solid green'
                this.errors.delete("nacionality")
            }
            if(this.mdata.telefono1 === ""){
                document.querySelector('#tel1').style.border = '1px solid red'
                this.errors.set("tel1",'El campo debe de ser llenado');
            }else{
                document.querySelector('#tel1').style.border = '1px solid green'
                this.errors.delete("tel1")
            }
            if(this.mdata.celular === ""){
                document.querySelector('#cel').style.border = '1px solid red'
                this.errors.set("cel",'El campo debe de ser llenado');
            }else{
                document.querySelector('#cel').style.border = '1px solid green'
                this.errors.delete("cel")
            }
            if(this.mdata.fecha_nacimiento === ""){
                document.querySelector('#birthDate').style.border = '1px solid red'
                this.errors.set("birthDate",'El campo debe de ser llenado');
            }else{
                document.querySelector('#birthDate').style.border = '1px solid green'
                this.errors.delete("birthDate")
            }
            if(this.mdata.lugar_residencia === ""){
                document.querySelector('#residence').style.border = '1px solid red'
                this.errors.set("residence",'El campo debe de ser llenado');
            }else{
                document.querySelector('#residence').style.border = '1px solid green'
                this.errors.delete("residence")
            }
            ////////////////////////////////////////////////////////////////////
            // if(this.mdata2.nombre_fallecido === ""){
            //     document.querySelector('#nameDead').style.border = '1px solid red'
            //     this.errors.set("nameDead",'El campo debe de ser llenado');
            // }else{
            //     document.querySelector('#nameDead').style.border = '1px solid green'
            //     this.errors.delete("nameDead")
            // }
            // if(this.mdata2.tipo_documento === ""){
            //     document.querySelector('#docDead').style.border = '1px solid red'
            //     this.errors.set("docDead",'El campo debe de ser llenado');
            // }else{
            //     document.querySelector('#docDead').style.border = '1px solid green'
            //     this.errors.delete("docDead")
            // }
            // if(this.mdata2.fecha_fallecimiento === ""){
            //     document.querySelector('#dateDead').style.border = '1px solid red'
            //     this.errors.set("dateDead",'El campo debe de ser llenado');
            // }else{
            //     document.querySelector('#dateDead').style.border = '1px solid green'
            //     this.errors.delete("dateDead")
            // }
            // if(this.mdata2.detalles_fallecimiento === ""){
            //     document.querySelector('#caseDetail').style.border = '1px solid red'
            //     this.errors.set("caseDetail",'El campo debe de ser llenado');
            // }else{
            //     document.querySelector('#caseDetail').style.border = '1px solid green'
            //     this.errors.delete("caseDetail")
            // }
        },
        changeView(){
            this.inpValidation();
            //Guard
            if(this.errors.size > 0) return;
            this.initial = !this.initial;
        },
        showSummary(){ this.summary = Summary }
    }
})
</script>

<style scoped>
</style>