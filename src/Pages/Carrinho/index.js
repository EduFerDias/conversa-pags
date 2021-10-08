import {Link} from 'react-router-dom'
import {useEffect, useState} from 'react'
 
import Cookies from 'js-cookie'
import CarrinhoItem from './carrinhoItem'
import Conteudo from './styled';

export default function Carrinho(){

    const [produtos, setProduto] = useState([]);

    useEffect(carregarCarrinho, []);

    function carregarCarrinho(){
        let carrinho = Cookies.get('carrinho');
        carrinho = carrinho != undefined
                    ? JSON.parse(carrinho)
                    : [];

        setProduto(carrinho);
    }

    function removerProduto(id) {
        let carrinho = produtos.filter(item => item.id !== id);
        Cookies.set('carrinho',JSON.stringify(carrinho));
        setProduto([...carrinho])
    }
    function alterarProduto(id, qtd){
        let produtoAlt = produtos.filter(item => item.id === id)[0];
        produtos.qtd = qtd;

        Cookies.set('carrinho', JSON.stringify(produtos));
    }

    return(
        <Conteudo>
            <div className="container">
                <h1>Carrinho</h1>
                <Link align="center" to="/">Voltar</Link>
                
                <div className="items">
                    {produtos.map(item => (
                        <CarrinhoItem key={item.id} info={item} onAlteration={alterarProduto} onRemove={removerProduto}/>
                    ))}
                </div>
            </div>
        </Conteudo>
    );
}