import { Produto } from "./produto";

export interface ItemVenda {
    id?: number;
    quantidade: number;
    preco: number;
    produto: Produto;
    produtoId: number;
    carrinhoId?: string;
    criadoEm?: Date;
}
