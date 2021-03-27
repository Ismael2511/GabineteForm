import { API_URL } from "../common/config";

const Maintenance = {
    // 1. Get Methods

    // 2. Save Methods
    async genericSave(method,mdata) {
        //http://localhost:52251/api/savePersona/{}
        const request = await fetch(API_URL + method + mdata)
        const data = await request.json();

        if(!data.ok) return new Error('Se produjo un Error guardando');

        return data;
    }

    // 3. Put / Patch Methods

    // 4. Delete / Inactivate Methods
}

export default Maintenance;