using server.Model;

namespace server.Data
{
    public class ProductData
    {
        public static List<ProductDto> datas = new()
        {
            new ProductDto { id = 1, name = "Fitbit Sense 2 智慧手錶", originalPrice = 1599, nowPrice = 1351, category = "穿戴裝置", stock = 80, description = "智慧手錶，健康監測功能", status = true, image = "/images/products/1.png", rate = 4 },
            new ProductDto { id = 2, name = "Apple iPhone 13 Pro（天峰藍）", originalPrice = 4590, nowPrice = 3989, category = "手機", stock = 89, description = "Apple旗艦手機", status = true, image = "/images/products/2.png", rate = 5 },
            new ProductDto { id = 3, name = "Apple MacBook Pro 13 吋", originalPrice = 4200, nowPrice = 3836, category = "筆電", stock = 37, description = "Apple筆記型電腦", status = true, image = "/images/products/3.png", rate = 5 },
            new ProductDto { id = 4, name = "Apple iMac 24 吋（綠色）", originalPrice = 2590, nowPrice = 2172, category = "電腦", stock = 10, description = "Apple一體機", status = true, image = "/images/products/4.png", rate = 4 },
            new ProductDto { id = 5, name = "Razer Kraken X 遊戲耳機", originalPrice = 1590, nowPrice = 1264, category = "耳機", stock = 58, description = "遊戲耳機", status = true, image = "/images/products/5.png", rate = 2 },
            new ProductDto { id = 6, name = "PlayStation 5 DualSense 控制器", originalPrice = 4800, nowPrice = 4140, category = "遊戲", stock = 29, description = "PS5控制器", status = true, image = "/images/products/6.png", rate = 5 },
            new ProductDto { id = 7, name = "Apple iPad Pro 12.9 吋（2021）", originalPrice = 3990, nowPrice = 3516, category = "平板", stock = 57, description = "Apple專業平板", status = true, image = "/images/products/7.png", rate = 5 },
            new ProductDto { id = 8, name = "Logitech K120 有線鍵盤", originalPrice = 3890, nowPrice = 3470, category = "周邊", stock = 61, description = "有線鍵盤", status = true, image = "/images/products/8.png", rate = 3 },
            new ProductDto { id = 9, name = "IKEA MARKUS 人體工學辦公椅", originalPrice = 1350, nowPrice = 1067, category = "家具", stock = 55, description = "人體工學辦公椅", status = true, image = "/images/products/9.png", rate = 4 },
            new ProductDto { id = 10, name = "Apple Magic Mouse 2", originalPrice = 3890, nowPrice = 3422, category = "周邊", stock = 49, description = "Apple無線滑鼠", status = true, image = "/images/products/10.png", rate = 4 },
            new ProductDto { id = 11, name = "Amazon Echo Dot 第4代", originalPrice = 3890, nowPrice = 3425, category = "家電", stock = 29, description = "智慧音箱", status = true, image = "/images/products/11.png", rate = 2 },
            new ProductDto { id = 12, name = "HORI Racing Wheel Apex for PlayStation", originalPrice = 3990, nowPrice = 3466, category = "遊戲", stock = 31, description = "PlayStation賽車方向盤", status = true, image = "/images/products/12.png", rate = 3 },
            new ProductDto { id = 13, name = "Nintendo Switch 主機（紅藍配色）", originalPrice = 3690, nowPrice = 3087, category = "遊戲", stock = 68, description = "任天堂遊戲主機", status = true, image = "/images/products/13.png", rate = 5 },
            new ProductDto { id = 14, name = "Oculus Rift S VR 頭盔", originalPrice = 3590, nowPrice = 3159, category = "穿戴裝置", stock = 69, description = "VR頭戴式裝置", status = true, image = "/images/products/14.png", rate = 4 },
            new ProductDto { id = 15, name = "Sony BRAVIA 4K LED 智慧電視", originalPrice = 3890, nowPrice = 3309, category = "電視", stock = 96, description = "Sony智慧電視", status = true, image = "/images/products/15.png", rate = 4 },
            new ProductDto { id = 16, name = "Apple AirPods Pro", originalPrice = 1590, nowPrice = 1349, category = "耳機", stock = 32, description = "Apple無線耳機", status = true, image = "/images/products/16.png", rate = 5 },
            new ProductDto { id = 17, name = "Xbox Series S 遊戲主機", originalPrice = 1890, nowPrice = 1561, category = "遊戲", stock = 97, description = "微軟遊戲主機", status = true, image = "/images/products/17.png", rate = 2 },
            new ProductDto { id = 18, name = "Seagate 外接硬碟", originalPrice = 3890, nowPrice = 3441, category = "電腦零件", stock = 47, description = "外接硬碟", status = true, image = "/images/products/18.png", rate = 3 },
            new ProductDto { id = 19, name = "Intel Core i9-11900K 處理器", originalPrice = 2490, nowPrice = 2142, category = "電腦零件", stock = 76, description = "Intel處理器", status = true, image = "/images/products/19.png", rate = 4 },
            new ProductDto { id = 20, name = "ASUS TUF Gaming 筆記型電腦", originalPrice = 3490, nowPrice = 2922, category = "筆電", stock = 56, description = "ASUS電競筆電", status = true, image = "/images/products/20.png", rate = 5 },
            new ProductDto { id = 21, name = "Levoit 智能超音波加濕器", originalPrice = 4590, nowPrice = 3963, category = "家電", stock = 33, description = "智能加濕器", status = true, image = "/images/products/21.png", rate = 4 },
            new ProductDto { id = 22, name = "Apple iMac 24吋 (藍色)", originalPrice = 3990, nowPrice = 3488, category = "電腦", stock = 40, description = "Apple一體機", status = true, image = "/images/products/22.png", rate = 4 },
            new ProductDto { id = 23, name = "ASUS ROG Rapture GT-AX6000 路由器", originalPrice = 2990, nowPrice = 2589, category = "網通", stock = 97, description = "ASUS路由器", status = true, image = "/images/products/23.png", rate = 1 },
            new ProductDto { id = 24, name = "Furinno 現代工業風書桌", originalPrice = 3890, nowPrice = 3482, category = "家具", stock = 27, description = "工業風書桌", status = true, image = "/images/products/24.png", rate = 3 },
            new ProductDto { id = 25, name = "RESPAWN RSP-110 電競椅", originalPrice = 1990, nowPrice = 1732, category = "家具", stock = 30, description = "電競椅", status = true, image = "/images/products/25.png", rate = 1 }
        };
    }
}
