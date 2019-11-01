import React, {Component} from 'react';
import {Text, View,} from 'react-native';
import {FlatList} from 'react-native-gesture-handler';

class Main extends Component {
    constructor() {
        super ();
        this.state = {
            medicos: [],
            nome: [],
            dataNasc: [],
            crm: [],
        }
    }

    componentDidMount(){
        this._carregarMedicos();
    }

    _carregarMedicos = async () => {
        await fetch('http://192.168.6.220:5000/api/medicos')
        .then(resposta => resposta.json())
        .then(data => this.setState({medicos: data}))
        .catch(erro => console.warn(erro));
    };

    render(){
        return(
            <FlatList
                data={this.state.eventos}
                keyExtractor={item => item.idMedico}
                renderItem={({item}) => (
                    <View>
                        <Text>{item.nome}</Text>
                        <Text>{item.dataNasc}</Text>
                        <Text>{item.crm}</Text>
                    </View>
                )}
            />
        );
    }
}

export default Main;