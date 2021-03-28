import { API_URL } from "../common/config";
import ApiService from "@/common/api.service";

const Maintenance = {
    // 1. GET Methods
    async getAll(method) {
        //http://localhost:52251/api/savePersona
        const request = await fetch(API_URL + method)
        const data = await request.json();

        if(!data.ok) return new Error('Se produjo un Error guardando');

        return data;
    },
    // 2. POST Methods
    async genericSave(method,mdata) {
        ApiService.post(API_URL + method,mdata)
        .then(data => {
            console.log(data)
        }).catch(err => console.log(err))
    },
    // 3. PUT / PATCH Methods

    // 4. DELETE / INACTIVATE Methods
}

export default Maintenance;