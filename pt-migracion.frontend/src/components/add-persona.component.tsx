import { Component, ChangeEvent } from "react";
import personaService from "../services/persona.service";
import IPersonaData from "../types/persona.type";

type Props = {};

type State = IPersonaData & {
    submitted: boolean
};

export default class AddPersona extends Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.onChangeNombre = this.onChangeNombre.bind(this); 

        // this.state = {
        //     id: "",
        //     Nombre: "",
        //     Apellido: "",
        //     FechaNacimiento: new Date,
        //     Pasaporte: 0,
        //     Direccion: "",
        //     Sexo: "",
        //     FotoPath: ""
        // }; 
    }

    onChangeNombre(e: ChangeEvent<HTMLInputElement>) {
        this.setState({
            Nombre: e.target.value
        });
    }

    onChangeApellido(e: ChangeEvent<HTMLInputElement>) {
        this.setState({
            Apellido: e.target.value
        });
    }

    savePersona() {
        const data: IPersonaData = {
          Nombre: this.state.Nombre,
          Apellido: this.state.Apellido,
          Direccion: this.state.Direccion,
          FechaNacimiento: this.state.FechaNacimiento,
          Pasaporte: this.state.Pasaporte,
          Sexo: this.state.Sexo,
          FotoPath: this.state.FotoPath
        };

        personaService.create(data)
            .then(response => {
                this.setState({
                    id: response.data.id,
                    Nombre: response.data.Nombre,
                    Apellido: response.data.Apellido,
                    Direccion: response.data.Direccion,
                    FechaNacimiento: response.data.FechaNacimiento,
                    Pasaporte: response.data.Pasaporte,
                    Sexo: response.data.Sexo,
                    FotoPath: response.data.FotoPath
                });
            }).catch(e => {
                console.log(e);
            });
    }

    newPersona(){
        this.setState({
            Apellido: "",
            Nombre: "",
            Direccion: "",
            FechaNacimiento: new Date,
            Pasaporte: 0,
            Sexo: "",
            FotoPath: ""
        });
    }

    render() {
        const { submitted, Nombre, Apellido, Direccion, FechaNacimiento, Pasaporte, Sexo, FotoPath } = this.state;

        return(
            <div className="submit-form">
                {submitted ? (
                    <div>
                        <h4>Persona creada exitosamente!</h4>
                        <button className="btn btn-success" onClick={this.newPersona}>Crear</button>
                    </div>
                ) : (
                    <div>
                        <div className="form-group">
                            <label htmlFor="Nombre">Nombre</label>
                            <input
                                type="text"
                                className="form-control"
                                id="Nombre"
                                required
                                value={Nombre}
                                onChange={this.onChangeNombre}
                                name="Nombre"
                            />
                        </div>
                        <div className="form-group">
                            <label htmlFor="Apellido">Apellido</label>
                            <input
                                type="text"
                                className="form-control"
                                id="Apellido"
                                required
                                value={Apellido}
                                onChange={this.onChangeApellido}
                                name="Apellido"
                            />
                        </div>

                        <button onClick={this.savePersona} className="btn btn-success">Guardar</button>
                    </div>
                )}
            </div>
        );
    }

}
