import styled from 'styled-components'

const Content = styled.div`
display: flex;
flex-direction: row;
align-items: center;

border-radius: 10px;
background-color: #f5f5f5;

.capa{
  width: 15em;
  padding-top: 100px;
  padding-left: 10em;
}
`

const Remover = styled.img`
  height: 50px;
  content: url('/assets/images/delete.svg');
`

export { Remover, Content }