import { useState } from "react";
import Cookies from "js-cookie";

import Contador from "../contador";
import { Remover, Content } from "./styled";

export default function CarrinhoItem(props){
    const [produto, setProduto] = useState(props.info);

    function alterarQtd(qtd){
        setProduto({...produto, qtd});

        props.onAlteration(produto.id, qtd);
    }

    function remover(){
        props.onRemove(produto.id);
    }

    return(
        <Content>
            <div>
                <img className="capa" src={produto.imagem} alt="" />
                <Contador onChange={alterarQtd} value={produto.qtd} />
            </div>

            <div className="titulo">
                {produto.titulo}
            </div>

            <div>
                <span>Preço unitário</span><br />
                {produto.preco}
            </div>

            <div className="qtd">
                <span>Qtd</span><br />
                {produto.qtd}
            </div>

            <div className="remove"><Remover onClick={remover}/></div>
        </Content>
    );
}