import Maintenance from "../services/Maintenance.js";

export const BaseView = {
    data(){
        return{
            // Each time a submit is made
            spinner: false,
            disableButton: false
        }
    },
    methods: {
        onSubmit() {
            this.spinner = this.disableButton = true 
            Maintenance.genericSave(this.methodSave,this.mdata)
            .then((data) => { 
                this.$emit('onSubmit', data);

                if(!data.successfull){
                    console.log('Error from BaseView= ',data)
                    this.spinner = this.disableButton = false
                }
            })
            .catch( (err) => {
                alert(new Error(err))
                location.reload()
            });
        },
        
    }
}