using System;
using System.Collections.Generic;
using System.Text;
using PedidoUsuario.Entities.Enums;

namespace PedidoUsuario.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
