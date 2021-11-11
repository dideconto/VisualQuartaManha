import { Component, OnInit } from "@angular/core";
import { ItemVenda } from "src/app/models/item-venda";
import { ItemVendaService } from "src/app/services/item-venda.service";

@Component({
    selector: "app-carrinho",
    templateUrl: "./carrinho.component.html",
    styleUrls: ["./carrinho.component.css"],
})
export class CarrinhoComponent implements OnInit {
    itens: ItemVenda[] = [];
    colunasExibidas: String[] = ["imagem", "nome", "preco", "quantidade"];
    valorTotal!: number;
    constructor(private itemService: ItemVendaService) {}

    ngOnInit(): void {
        let carrinhoId = localStorage.getItem("carrinhoId")! || "";
        this.itemService.getByCartId(carrinhoId).subscribe((itens) => {
            this.itens = itens;
            this.valorTotal = this.itens.reduce((total, item) => {
                return total + item.preco * item.quantidade;
            }, 0);
        });
    }
}
