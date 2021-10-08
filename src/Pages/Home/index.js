import { Link } from "react-router-dom";
import Conteudo from "./styled";
import SaleBox from '../../components/SaleBox'
import { useState } from "react";


export default function Home (){

    const [ cat, setCat ]  = useState([])


    function Listar(){
                            
        var products = [
            {
                id:1,
                nome:"Miniatura - Maclaren 2008 - MP4-23",
                descricao:"Minatura do carro de formula 1 do ano 2008 da Maclaren",
                imagem:"http://www.minimundi.com.br/cdn/imagens/produtos/det/miniatura-carro-formula-1-vodafone-mclaren-mercedes-mp4-23-keikki-kovalainen-saison-2008-1-43-minichamps-b66962423-021370_a.jpg",
                preco: 249.90,
                especificacoes: "Miniatura de Boa Qualidade, Item de colecionador"
            },
            {
                id:2,
                nome:"Poster Imola 2021 - GP Italia",
                descricao:"Poster Celebrativo do Grande Prêmio da Italia 2021",
                imagem:"https://www.italy24news.com/content/uploads/2021/04/01/2377f7e2e3.jpg",
                preco: 30.00,
                especificacoes: "Exelente qualidade, bom item decorativo para Suas Paredes!"
            },
            {
                id:1,
                nome:"Miniatura - Maclaren 2008 - MP4-23",
                descricao:"Minatura do carro de formula 1 do ano 2008 da Maclaren",
                imagem:"http://www.minimundi.com.br/cdn/imagens/produtos/det/miniatura-carro-formula-1-vodafone-mclaren-mercedes-mp4-23-keikki-kovalainen-saison-2008-1-43-minichamps-b66962423-021370_a.jpg",
                preco: 249.90,
                especificacoes: "Miniatura de Boa Qualidade, Item de colecionador"
            }
        ]
        setCat(products)
        ;
    }

    return(
        <Conteudo>
            <div className="container">
                <div className="titulo"><h1>Seja Bem vindo!</h1></div>
                <div className="buttons">
                    <button onClick={Listar}>Comprar!</button>
                </div>

                <Link to="/contador">
                <div className="buttons">
                    <button>Contador</button>
                </div>
                </Link>
            </div>


            <div className="products">
                    {cat.map((item => (
                        <SaleBox info={item}/>
                    )))}
            </div>
        </Conteudo>
    );
}
