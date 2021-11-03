import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Categoria } from "src/app/models/categoria";
import { Produto } from "src/app/models/produto";
import { CategoriaService } from "src/app/services/categoria.service";
import { ProdutoService } from "src/app/services/produto.service";

@Component({
    selector: "app-cadastrar-produto",
    templateUrl: "./cadastrar-produto.component.html",
    styleUrls: ["./cadastrar-produto.component.css"],
})
export class CadastrarProdutoComponent implements OnInit {
    nome!: string;
    descricao!: string;
    quantidade!: number;
    preco!: number;
    categorias!: Categoria[];
    categoriaId!: number;

    constructor(
        private produtoService: ProdutoService,
        private categoriaService: CategoriaService,
        private router: Router
    ) {}

    ngOnInit(): void {
        this.categoriaService.list().subscribe((categorias) => {
            this.categorias = categorias;
            console.table(categorias);
        });
    }

    cadastrar(): void {
        let produto: Produto = {
            nome: this.nome,
            descricao: this.descricao,
            quantidade: this.quantidade,
            preco: this.preco,
            categoriaId: this.categoriaId,
        };
        this.produtoService.create(produto).subscribe((produto) => {
            this.router.navigate(["produto/listar"]);
        });
    }
}
