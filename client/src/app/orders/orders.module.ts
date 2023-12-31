import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OrdersComponent } from './orders.component';
import { OrderDetailedComponent } from '../order-detailed/order-detailed.component';
import { OrdersRoutingModule } from './orders-routing.module';
import { AppModule } from '../app.module';

@NgModule({
  declarations: [OrdersComponent],
  imports: [CommonModule, OrdersRoutingModule],
})
export class OrdersModule {}
