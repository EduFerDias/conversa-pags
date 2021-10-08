import styled from 'styled-components'

const Content = styled.div`
display: flex;
flex-direction: row;
align-items: center;
cursor: default;

border-radius: 10px;
background-color: #4D4D4D;
width: max-content;
align-self: center;
padding-right: 1em;

.capa{
  width: 15em;
  padding-top: 100px;
  padding-left:4.5em;
}

.preco, .titulo, .qtd{
  padding: 0px 0.5em;
}

margin-bottom: 30px;
`

const Remover = styled.img`
  height: 50px;
  cursor: pointer;
  content: url('/assets/images/delete.svg');
`

export { Remover, Content }