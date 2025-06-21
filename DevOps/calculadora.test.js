function soma (a,b){
    return a+b
}
function subtraçao (a,b){
    return a-b
}
function divisao (a,b){
    return a/b
}
function mult(a,b){
    return a*b
}

/*
toBe: Igualdade
toEqual: Valor de um obj
toBeGreaterThan: Valor maior
toBeGreaterThanOrEqual: Valor maior ou igual
toBeLessThan(5): Valor é menor
toBeLessThanOrEqual: Valor é menor ou igual
*/

describe('Testar funções da calculadora', () => {
    //test e o it é a mesma coisa
    test('Testando soma', () => {
        const esperado = 25;
        const retorno = soma(15,10)
        expect(retorno).toBe(esperado)
    })

    test('Testando subtração', () => {
        const esperado = 5;
        const retorno = subtraçao(15,10)
        expect(retorno).toBe(esperado)
    })

    test('Testando divisão', () => {
        const esperado = 5;
        const retorno = divisao(10,2)
        expect(retorno).toBe(esperado)
    })

    test('Testando multiplicacao', () => {
        const esperado = 20;
        const retorno = mult(10,2)
        expect(retorno).toBe(esperado)
    })

   /* it('Testando soma de 2 nºs', () => {
        const esperado = 23;
        const retorno = soma(15,10)
        expect(retorno).toBe(esperado)
    })*/
}
)