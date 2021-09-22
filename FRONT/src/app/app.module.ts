import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { HttpClientModule } from "@angular/common/http";
import { CadastrarProdutoComponent } from './components/views/produto/cadastrar-produto/cadastrar-produto.component';
import { ListarProdutoComponent } from './components/views/produto/listar-produto/listar-produto.component';

@NgModule({
    declarations: [AppComponent, CadastrarProdutoComponent, ListarProdutoComponent],
    imports: [BrowserModule, AppRoutingModule, HttpClientModule],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}
