import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { ItemVenda } from "src/app/models/item-venda";
import { Produto } from "src/app/models/produto";
import { ProdutoService } from "src/app/services/produto.service";

@Component({
    selector: "app-index",
    templateUrl: "./index.component.html",
    styleUrls: ["./index.component.css"],
})
export class IndexComponent implements OnInit {
    produtos!: Produto[];
    itens: ItemVenda[] = [];

    constructor(
        private produtoService: ProdutoService,
        private router: Router
    ) {}

    ngOnInit(): void {
        this.produtoService.list().subscribe((produtos) => {
            this.produtos = produtos;
        });
        this.itens = JSON.parse(localStorage.getItem("itens")!) || [];
    }

    adicionar(produto: Produto): void {
        let item: ItemVenda = {
            produto: produto,
            quantidade: 1,
            preco: produto.preco,
            produtoId: produto.id!,
        };
        this.itens.push(item);
        localStorage.setItem("itens", JSON.stringify(this.itens));
        this.router.navigate(["/venda/carrinho"]);
    }
}
