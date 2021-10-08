import { useState } from 'react'

export default function PaiCounter (){
    const [ Count, setCounter ] = useState(0);

    function contar (){
        let conta = Count + 1;
        setCounter(conta)
        return;
    };

    function resetar(x){
        setCounter(x)
    }

    return(
        <div>
            <h1>Contador</h1>
            <div>{Count} &nbsp; <button onClick={contar}>Contar!</button></div>
            <div><FilhoCouter onReset={resetar}/></div>
        </div>
    )
}

function FilhoCouter (props){
    function reset(){
        props.onReset(0)
    }


    return(
        <div>
            <button onClick={reset}>Reiniciar Contador</button>
        </div>
    );
}