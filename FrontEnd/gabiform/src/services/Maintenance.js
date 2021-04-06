import { API_URL } from "../common/config";
import ApiService from "@/common/api.service";

const Maintenance = {
    // 1. ANCHOR  GET Methods

    async getAll(method) {
        const request = await fetch(API_URL + method)
        const data = await request.json();

        if(!data.ok) {
            alert(new Error('Se produjo un Error guardando'));
            return location.reload(); 
        }

        return data;
    },
    async getById(method,id){
        ApiService.getId(method,id)
    },

    // 2. ANCHOR POST Methods

    genericSave(method,mdata) {
        return new Promise((resolve) => {
            ApiService.post(API_URL + method,mdata)
            .then(({data}) => {       
                resolve(data)
            })  
            .catch(() => {
                alert(new Error("Ha ocurrido un error con el servidor"));
                location.reload()
            }); 
        });
    },
    
    // 3. ANCHOR PUT / PATCH Methods

    // 4. ANCHOR DELETE / INACTIVATE Methods

    async inactivateItem(method,element) {
        const item = await this.getById(method,element);
        return new Promise(resolve => {
            ApiService.post(API_URL + method + item)
            .then(data => {
                resolve(data);
            })
        })
        
    }
}

export default Maintenance;