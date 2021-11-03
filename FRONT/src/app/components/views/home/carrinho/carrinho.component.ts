import { Component, OnInit } from "@angular/core";
import { ItemVenda } from "src/app/models/item-venda";

@Component({
    selector: "app-carrinho",
    templateUrl: "./carrinho.component.html",
    styleUrls: ["./carrinho.component.css"],
})
export class CarrinhoComponent implements OnInit {
    itens: ItemVenda[] = [];
    colunasExibidas: String[] = ["imagem", "nome", "preco", "quantidade"];
    valorTotal!: number;

    constructor() {}

    ngOnInit(): void {
        this.itens = JSON.parse(localStorage.getItem("itens")!) || [];
        this.valorTotal = this.itens.reduce((total, item) => {
            return total + item.preco * item.quantidade;
        }, 0);
    }
}
