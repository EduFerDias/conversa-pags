let x1 = kilo =>  kilo * 1000

let x2 = (n1, n2, n3) =>{
    let notaF = (n1 * n2 * n3)/3;
    let passou = notaF >= 5;
    return passou;
}

let x3 = email => email.includes('@')

let x4 = ton => ton * 1000

let x5 = (qtdP, qtdM, qtdG) =>{

    let preco_p = qtdP * 10;
    let preco_m = qtdM * 12;
    let preco_g = qtdG * 14;
    return preco_g + preco_m + preco_p;

}

let x6 = (acertos10, acertos25, acertos50) =>{
    let pontos10 = acertos10 * 10;
    let pontos25 = acertos25 * 25;
    let pontos50 = acertos50 * 50;

    return pontos10 + pontos25 + pontos50;
}

function calcPrecoCarro(precoCarro, nParcelas, taxa){
    let juros = precoCarro * nParcelas * (taxa/100);
    let total = precoCarro + juros;
    return total;
}

let x7 = (precoCarro, nParcelas) => calcPrecoCarro(precoCarro, nParcelas, 5)


let x8 = (gramaPMarmita, nPessoas) => {
    let marmitasKg = gramaPMarmita / 1000;
    let qtdAlimentosKg = marmitasKg * nPessoas; 
    return qtdAlimentosKg;
}

let x9 = (valorCompra, parcelas, garantia, frete) => {
    let garantiaV = valorCompra * garantia * 0.05;
    let valorComp = valorCompra + frete + garantiaV;
    let juros = valorComp * parcelas * 0.02;
    return juros + valorComp
}

let x10 = (base, altura) => base * altura

console.log('x1: ' + x1(4))
console.log('x2: ' + x2(6, 7 ,8))
console.log('x3: ' + x3('josephDantas@145mail.com.br'))
console.log('x4: ' + x4(7))
console.log('x5: ' + x5(4, 2, 1))
console.log('x6: ' + x6(4, 1, 2))
console.log('x7: ' + x7(25000, 12))
console.log('x8: ' + x8(800, 2000))
console.log('x9: ' + x9(5000, 12, 3, 100))
console.log('x10: ' + x10( 8, 6))