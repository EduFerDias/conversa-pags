import Cookies from 'js-cookie';
import { useState } from 'react'
import { Link, useHistory } from 'react-router-dom'
import Conteudo from './styled';

export default function DetProduto(props){
    const [ produto, setProduto ] = useState(props.location.state);
    let nav = useHistory();

    function comprar(){
        let carrinho = Cookies.get('carrinho')
        carrinho = carrinho !== undefined
                    ? JSON.parse(carrinho)
                    : [];

        if(carrinho.some(item => item.id === produto.id) === false)
            carrinho.push({...produto, qtd: 1})

        Cookies.set('carrinho', JSON.stringify(carrinho));

        nav.push('/carrinho')
    }

    return(
        <Conteudo>
            <div className="b1">
                <Link to="/">Voltar</Link>


                <h1 className="t1" >Detalhes do Produto</h1>
                <br /> <br/>
                
                <div><img src={produto.imagem} alt="" /></div>
                <div><h1>{produto.nome}</h1></div>
                <div><h3>{produto.preco.toFixed(2)}</h3></div>
            </div>
            <div className="b2">
                <h2>Descrição do Produto</h2>
                <div>{produto.descricao}</div>

                <h2>Especificações do produto</h2>
                <div>{produto.especificacoes}</div>

                <div><button onClick={comprar}>Comprar</button></div>
            </div>
        </Conteudo>
    )
}