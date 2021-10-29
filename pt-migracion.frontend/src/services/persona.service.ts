import http from "../http-common";
import IPersonaData from "../types/persona.type";

class PersonaDataService {
    getAllPersona() {
        return http.get("/persona");
    }

    get(id: string) {
        return http.get(`/personaid/${id}`);
    }

    create(data: IPersonaData){
        return http.post("/persona", data);
    }
}

export default new PersonaDataService();