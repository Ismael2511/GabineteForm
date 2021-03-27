import Maintenance from "../services/Maintenance.js";

export const BaseView = {
    data(){
        return{
            spinner: false
        }
    },
    methods: {
        async onSubmit() {
            console.log(this.mdata)

            await Maintenance.genericSave(this.methodSave, this.mdata)
            .then( data => {
                this.spinner = true
                if(data.success) return console.log('Success')
                 
                console.log('Failed')
            }).catch( ex => {console.log(ex); this.spinner = false});
        }
    }
}