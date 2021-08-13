import Message from './Chat-prop'
import { Chat } from './Chat-style';

const Messages =[
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Só um teste rapido"},
                    {name: "Brunex", message:"Consegue achar o diferente?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa Tudo bem aí?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Opa, Tudo bem ai?"},
                    {name: "Brunex", message:"Boa Sorte!"}
                ]

export default function ChatDisplay(){
    return(
        <Chat>
            <div className="message">(15:02:01) <b>Brunex</b> Entrou na Sala... </div>

            {Messages.map((item) => (
                <Message name ={item.name} message ={item.message} />
            ))}

            <div className="message">(15:03:25) <b>Brunex</b> Saiu da Sala...</div>
        </Chat>
    );
}