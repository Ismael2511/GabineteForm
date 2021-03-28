import Maintenance from "../services/Maintenance.js";

export const BaseView = {
    data(){
        return{
            spinner: false
        }
    },
    methods: {
        async onSubmit() {
            await Maintenance.genericSave(this.methodSave, this.mdata)
            .then( data => {
                this.spinner = true
                // if(data) return console.log('Success')
                 console.log(data)
            }).catch( ex => {console.log('Fallo',ex); this.spinner = false});
        }
    }
}