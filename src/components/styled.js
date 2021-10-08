import styled from "styled-components";

const Conteudo = styled.div`
    display: flex;
    flex-direction: column;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    font-weight: 500;
    width: 10em;
    padding: 1.4em 1.5em 2em 1.5em;
    margin: 0 30px;
    height: 15em;

    background-color: #343434B2;
    border-radius: 5px;
    box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);

    img{
        align-self: center;
        width: 10em;
        padding-bottom: 1rem;
    }

    button{
        margin-top: 2rem;

        font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        font-weight: 600;
        width: 100%;
        padding: 1em 0em;

        color: white;
        background-color: #2b2b2b;

        border: none;
    }

    .preco{
        color:white;
    }
    a{
        height: 100%;
    }
`

export default Conteudo;