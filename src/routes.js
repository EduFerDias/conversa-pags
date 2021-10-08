import { BrowserRouter, Switch, Route } from "react-router-dom";
import Carrinho from "./Pages/Carrinho";
import PaiCounter from "./Pages/Contador";
import DetProduto from "./Pages/DetalheProduto";
import Home from './Pages/Home'


export default function Routes () {
    return(
        <BrowserRouter>
            <Switch>
                <Route path="/" component={Home} exact={true}/>
                <Route path="/contador" component={PaiCounter} />
                <Route path="/detalhe" component={DetProduto} />
                <Route path="/carrinho" component={Carrinho} />
            </Switch>
        </BrowserRouter>
    );
}