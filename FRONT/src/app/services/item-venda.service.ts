import { ItemVenda } from "../models/item-venda";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
    providedIn: "root",
})
export class ItemVendaService {
    private baseURL = "http://localhost:5000/api/item";

    constructor(private http: HttpClient) {}

    getByCartId(carrinhoId: string): Observable<ItemVenda[]> {
        return this.http.get<ItemVenda[]>(
            `${this.baseURL}/getbycartid/${carrinhoId}`
        );
    }

    create(item: ItemVenda): Observable<ItemVenda> {
        return this.http.post<ItemVenda>(`${this.baseURL}/create`, item);
    }
}
