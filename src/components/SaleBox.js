import Conteudo from './styled'
import { Link } from 'react-router-dom'

export default function SaleBox (props){
    return(
        <Conteudo>
            <img src={props.info.imagem} alt=''/>
            <div className="double">
                <span>{props.info.nome}</span>
            </div>
            <Link to={{
                pathname: 'detalhe',
                state: props.info
            }}>
            <span className="preco">R$ {props.info.preco.toFixed(2)} </span>
            <button>Saiba Mais!</button>
            </Link>
        </Conteudo>
    );
}