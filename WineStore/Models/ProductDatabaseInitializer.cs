using System.Collections.Generic;
using System.Data.Entity;

namespace WineStore.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "White Wine"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Red Wine"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Champagne"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Rose"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Sparkling Wine"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "LA PODEROSA SAUVIGNON BLANC 2015",
                    Description = "A perfect match for shellfish or grilled sardines. Great with Thai and other Asian cuisine or just for drinking on its own.This brilliant value dry white from Chile has been made to be enjoyed when youthful and fresh.Made from Sauvignon Blanc grapes the palate is clean and fresh and full of mouth-watering citrus fruit.", 
                    ImagePath="WB1.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "CHARDONNAY BARON PHILIPPE 2014",
                    Description = "Don’t let the price of Baron de Rothschild’s newest range of wines fool you - these are superb tasting wines at a great price. Using single grape varieties for each bottle, the top producing family have created simple, easy drinking wines that you’ll be coming back to time and time again. Dry and crisp like a good chardonnay should be. Citrus fruits and white peach flavours mingled with floral notes lead the palate with a crisp mineral finish. An uncomplicated chardonnay that is easily drinkable with or without food. Superb value from a well-known producer.",
                    ImagePath="WB2.png",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "VIOGNIER BARON PHILIPPE  2014",
                    Description = "Baron de Rothschild’s latest range of single grape wines falls into the category of house wine, but don’t let that fool you. This is a superb wine at a great price.Exotic stone fruits dominate the palate with light floral notes and hints of almond. Clean and zesty, the Viognier is best drunk young for the exotic fruit flavours but ageing will bring out a nuttiness to the wine, especially in the finish. The richness of a viognier is better with heavier dishes such as a mild creamy curry.",
                    ImagePath="WB3.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "TERRAMORE, PINOT GRIGIO  2014",
                    Description = "Delightfully dry, intense in flavour but delicate in the mouth - this is a little more than your average Pinot Grigio. This wine has an extra weight that makes it an ideal accompaniment to a fish main course.They only make 1000 cases of this delicious white – so we couldn’t resist adding it to our autumn/winter line up.",
                    ImagePath="WB4.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "SIÓS PLA DEL LLADONER 2013",
                    Description = "An unapologeticly rich and unctuous wine but one that leaves a freshness in your mouth. Harmonious and complex, it’s a style that goes well with seafood dishes or would pair perfectly with grilled chicken or turkey. An estate wine, from the “Pla del Lladoner” vineyard. Grapes are handpicked and transported in small boxes, to protect them. Grapes are 80% Chardonnay and 20% Viognier.",
                    ImagePath="WB5.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "LA PODEROSA MALBEC 2014",
                    Description = "This excellent value Chilean wine has a juicy mix of dark fruit and peppery spice. It has a lighter body most wines produced from the Malbec grape, which means it makes a fantastic match with white meat and with dishes with a bit of spice, like empanadas.Malbec thrives in this part of the world, and is planted widely across both Argentina and Chile. The La Poderosa brand was created by the highly regarded Chilean winery Viña Luis Felipe Edwards, to honour Ernesto “Che” Guevara’s journey across Chile on his precious Norton 500 motorbike, as told in The Motorcycle Diaries.",
                    ImagePath="RB1.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "SYRAH BARON PHILIPPE 2014",
                    Description = "Baron de Rothschild’s latest range of single grape wines falls into the category of house wine, but don’t let that fool you. The varietal range of pay d’Oc wine is superb quality at a great price. Powerful and rich, the Syrah is the most complex of the varietal range. A fresh palate bursting with dark fruits and hints of black pepper. A great match for a steak or rich beef bourguignon.",
                    ImagePath="RB2.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "MONTAÑÉS MALBEC ARGENTINA 2014",
                    Description = "A classic, Argentinian Malbec, the Montañés 2014 release is an excellent partner to spring lamb, summer barbeques, autumnal game and hot roast beef come winter.On the nose, spicy mocha underlines the open fruitiness of the Malbec grape with notes of raspberry and rich fruit. On the palate, the taste is rich and vibrant with dark red fruits, round tannins and a pleasant finish.The structure also allows for further ageing for a year or two in the bottle, but we’d recommend opening a bottle now to enjoy on an evening with a warming bowl of pappardelle and slow-cooked beef ragu.",
                    ImagePath="RB3.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "MOORE’S CABERNET SAUVIGNON 2012",
                    Description = "Aromas of black cherries, wild berries and a tweak of spice. This is a rich, full-bodied red with intense plummy flavours. It’s fruitness is balanced by firm tannins.This blend is made using grapes from specially-selected vineyards in Australia’s premium Cabernet Sauvignon regions. The fruit is fermented in stainless steel potter tanks with regular ‘pumping over’ (of the wine over the skins) to ensure optimum colour, tannin and flavour. After fermentation, the wine is matured in a mixture of French and American oak before bottling.",
                    ImagePath="RB4.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "TERRAZAS DE LOS ANDES MALBEC 2013",
                    Description = "If you’re looking for bang-for-your-buck, you just found it.This full-bodied wine from Argentina’s Mendoza region comes with a splash of French ‘savoir faire’ - the winemaker learned expertise at the famous Château Cheval Blanc in Bordeaux’ Saint-Emilion, making this a premium Malbec with real pedigree.This Malbec has enough punch to match with tasty, rich foods like rump steak or even chilli con carne.",
                    ImagePath="RB5.png",
                    UnitPrice = 15.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "MOËT & CHANDON CHAMPAGNE",
                    Description = "Gorgeous pink Champagne in half-sized bottle, for gifts, goody bags or add some serious luxury to your picnics.More than 100 different wines are blended to create this classic Rosé Champagne. It has floral scents, then it explodes in your mouth into a red fruit-filled bomb, with strawberry, raspberry, cherry and redcurrant with a touch of spice all coming together with beautiful balance..",
                    ImagePath="CB1.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "DOM PÉRIGNON 1998 CHAMPAGNE",
                    Description = "The maturation of Dom Pérignon occurs in successive “leaps into new expressions”, each of which are called plénitudes. P2 means this is the Second Plénitude of this 1998 Vintage Champagne. The P1 (in 2005) was incredibly balanced. Now, the wine has gained some youthful zing. After 16 years in the dark DP cellars, the P2 has a sharper intensity. The aromatic persistence progresses like a wave that stimulates the penetrating nature of the wine. It tastes mineral, with a little iodine and spice: “Like any high-tech creation, it reveals itself in high definition.”",
                    ImagePath="CB2.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "THOMSON SKINNY PROSECCO",
                    Description = "Thomson & Scott SKINNY Prosecco is the delicious brainchild of entrepreneur Amanda Thomson.Raised sugar-free, she made it her mission to bring to the market beautifully crafted drinks with the benefit of no and low sugar.The original Thomson & Scott Skinny Champagne with no added sugar has now been joined by Skinny Prosecco, which boasts all the traits of a traditional Prosecco, but with 50% less sugar. Not only that, but Thomson & Scott Skinny Prosecco is organic, suitable for vegans and contains just 67 calories per glass.",
                    ImagePath="CB3.png",
                    UnitPrice = 95.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "G. H. MUMM CORDON ROUGE",
                    Description = "Mumm Cordon Rouge is an intensely fruity Champagne with fresh, delicate bubbles for a smooth and easy-drinking experience.Crafted from grapes sourced from over 75 different Crus across the Champagne region, G.H. Mumm Cordon Rouge is the house’s signature cuvee and perfect for any celebration.The nose reveals initial aromas of ripe fruit (green apples, white and yellow peaches, apricots), tropical notes (lychee, pineapple) and bursts into a freshness on the palate, followed by great length in the mouth, and those subtle, rich bubbles. The Cordon Rouge’s aromatic richness is a perfect match for white meat, monkfish or red mullet, and is also an ideal complement to the creamy flavours of foie gras.",
                    ImagePath="CB4.png",
                    UnitPrice = 4.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "PERRIER-JOUËT GRAND CHAMPAGNE",
                    Description = "The Grand Brut effortlessly mixes the staple three Champagne grapes (Chardonnay, Pinot Noir, and Pinot Meunier) together to create an intricate yet lively wine. Perrier-Jouët is one of the finest Champagne Houses in the world and known for the elegance of its wines. It is also the first to have created a dry Champagne, which led to the production of its famous Brut in 1856.With fruity and floral notes merging with one another to create a delicately smooth taste, unique flavours such as pineapple and grapefruit appear on the palate to separate this from the competition. It’s these surprises that gives this balanced Grand Brut such a fantastic reputation.",
                    ImagePath="CB5.png",
                    UnitPrice = 42.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "SCOTT SKINNY PROSECCO",
                    Description = "Thomson & Scott SKINNY Prosecco is the delicious brainchild of entrepreneur Amanda Thomson.Raised sugar-free, she made it her mission to bring to the market beautifully crafted drinks with the benefit of no and low sugar.The original Thomson & Scott Skinny Champagne with no added sugar has now been joined by Skinny Prosecco, which boasts all the traits of a traditional Prosecco, but with 50% less sugar. Not only that, but Thomson & Scott Skinny Prosecco is organic, suitable for vegans and contains just 67 calories per glass.",
                    ImagePath="CB6.png",
                    UnitPrice = 122.95,
                    CategoryID = 3
                }
            };

            return products;
        }
    }
}