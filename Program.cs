
using System;
using System.Collections.Generic;

namespace World_of_Foods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*The SweetCookbook Class in C#er Side♡*");

            bool Exit = false;
            while (!Exit)
            {
                Console.WriteLine("\nChoose your continent:");
                Console.WriteLine("1. Asia");
                Console.WriteLine("2. America");
                Console.WriteLine("3. Europe");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n–––Asia–––");
                        List<string> AsiaPlace = new List<string>
                        {
                            " China",
                            " Thailand",
                            " Philippines"
                        };
                        DisplayPlaces(AsiaPlace);
                        break;
                    case 2:
                        Console.WriteLine("\n–––America–––");
                        List<string> AmericaPlace = new List<string>
                        {
                            " Colombia",
                            " Argentina",
                            " Brazil"
                        };
                        DisplayPlaces(AmericaPlace);
                        break;
                    case 3:
                        Console.WriteLine("\n–––Europe–––");
                        List<string> EuropePlace = new List<string>
                        {
                            " Italy",
                            " France",
                            " Greece"
                        };
                        DisplayPlaces(EuropePlace);
                        break;
                    case 4:
                        Exit = true;
                        Console.WriteLine("\nThank you for using our service");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                if (Exit)
                {
                    break;
                }

                Console.Write("\nEnter your chosen country: ");
                int chosen = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        switch (chosen)
                        {
                            case 1:
                                Console.WriteLine("\nFoods in China:");
                                List<string> CFoods = new List<string>
                                {
                                    "Peanut Butter Bun",
                                    "Curry Beef Triangle",
                                    "Nuomici"
                                };
                                DisplayCountries(CFoods);
                                break;
                            case 2:
                                Console.WriteLine("\nFoods in Thailand:");
                                List<string> ThaiFoods = new List<string>
                                {
                                    "Mango Sticky Rice",
                                    "Pa Thong Ko",
                                    "Bua Loi"
                                };
                                DisplayCountries(ThaiFoods);
                                break;
                            case 3:
                                Console.WriteLine("\nFoods in the Philippines:");
                                List<string> PHFoods = new List<string>
                                {
                                    "Hopia (Monggo)",
                                    "Buko Pie",
                                    "Ensaymada"
                                };
                                DisplayCountries(PHFoods);
                                break;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                        break;
                    case 2:
                        switch (chosen)
                        {
                            case 1:
                                Console.WriteLine("\nFoods in U.S.A.:");
                                List<string> USAFoods = new List<string>
                                {
                                    "Almond Bear Claw",
                                    "Cronut",
                                    "Malasadas"
                                };
                                DisplayCountries(USAFoods);
                                break;
                            case 2:
                                Console.WriteLine("\nFoods in Canada:");
                                List<string> CanadianFoods = new List<string>
                                {
                                    "Beaver Tails",
                                    "Timbits",
                                    "Blueberry Grunt"
                                };
                                DisplayCountries(CanadianFoods);
                                break;
                            case 3:
                                Console.WriteLine("\nFoods in Argentina:");
                                List<string> ArgentinaFoods = new List<string>
                                {
                                    "Medialunas",
                                    "Empanadas Tucumanas",
                                    "Pastelitos Criollos"
                                };
                                DisplayCountries(ArgentinaFoods);
                                break;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                        break;
                    case 3:
                        switch (chosen)
                        {
                            case 1:
                                Console.WriteLine("\nFoods in Italy:");
                                List<string> ItalianFoods = new List<string>
                                {
                                    "Genovesi",
                                    "Seada",
                                    "Struffoli"
                                };
                                DisplayCountries(ItalianFoods);
                                break;
                            case 2:
                                Console.WriteLine("\nFoods in France:");
                                List<string> FranceFoods = new List<string>
                                {
                                    "Dariole",
                                    "Rissole",
                                    "Flan Pâtissier"
                                };
                                DisplayCountries(FranceFoods);
                                break;
                            case 3:
                                Console.WriteLine("\nFoods in Greece:");
                                List<string> GreeceFoods = new List<string>
                                {
                                    "Kalitsounia",
                                    "Diples",
                                    "Loukoumades"
                                };
                                DisplayCountries(GreeceFoods);
                                break;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
				
				if (Exit)
				{
				  break;
				}
				
				Console.Write("\nChoose the food you want to know the ingredients: ");
				int foodChoice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						switch (chosen)
						{
							case 1:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Peanut Butter Bun:");
										Console.WriteLine(" - 300 g Bread flour");
										Console.WriteLine(" - 1 tsp dry  yeast");
										Console.WriteLine(" - 1/2 tsp salt");
										Console.WriteLine(" - 20 gm milk powder");
										Console.WriteLine(" - 30 gm caster sugar");
										Console.WriteLine(" - 150 ml icewater(may need a bit more or a bit less)");
										Console.WriteLine(" - 30 gm softened butter");
										Console.WriteLine(" - Peanut butter, crunchy or creamy");
										Console.WriteLine(" - 1 egg plus 2 tsp water");
										Console.WriteLine(" - Raw sugar to sprinkle (optional)");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Curry Beef Triangle:");
										Console.WriteLine(" - 350g beef mince");
										Console.WriteLine(" - 1/2 small onion, chopped");
										Console.WriteLine(" - 1 garlic clove, crushed");
										Console.WriteLine(" - 1 1/2 tsp curry powder");
										Console.WriteLine(" - 1/4 cup (40g) frozen peas");
										Console.WriteLine(" - 1 tsp cornflour");
										Console.WriteLine(" - 8 sheets filo pastry");
								        Console.WriteLine(" - natural yoghurt, to serve");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Nuomici:");
										Console.WriteLine(" - 100 grams crumbled roasted peanuts (unsalted)");
										Console.WriteLine(" - 200 grams desiccated coconut");
										Console.WriteLine(" - 2 tablespoons sugar");
										Console.WriteLine(" - 20 grams natural coconut oil");
										Console.WriteLine(" - 120 grams glutinous rice flour");
										Console.WriteLine(" - 50 grams sugar powder");
										Console.WriteLine(" - 30 grams corn starch");
										Console.WriteLine(" - 20 grams natural coconut oil");
										Console.WriteLine(" - 100 grams milk");
										Console.WriteLine(" - 100 grams condensed coconut milk");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							case 2:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Mango Sticky Rice:");
										Console.WriteLine(" - 1 cup Thai sweet rice (aka sticky rice)");
										Console.WriteLine(" - 1 1/2 cups water, divided");
										Console.WriteLine(" - 1 (13.5-ounce) can coconut milk, divided");
										Console.WriteLine(" - 1/4 teaspoon salt");
										Console.WriteLine(" - 4 to 5 tablespoons brown sugar, to taste, divided");
										Console.WriteLine(" - 1 to 2 ripe mangoes");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Pa Thong Ko:");
										Console.WriteLine(" - 3 Cups All Purpose Flour");
										Console.WriteLine(" - 1 Cup Water");
										Console.WriteLine(" - 1 Teaspoon Baking Powder");
										Console.WriteLine(" - 1/4 Teaspoon Baking Soda");
										Console.WriteLine(" - 1 Teaspoon Sugar");
										Console.WriteLine(" - 1 Tablespoon Vegetable Oil");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Bua Loi:");
										Console.WriteLine(" - Sweet Potato Bua Loy Ingredients:");
										Console.WriteLine(" - 50 grams (about ½ cup roughly diced) sweet potato, steamed");
										Console.WriteLine(" - 55 grams (½ cup) sticky rice flour");
										Console.WriteLine(" - Water");
										Console.WriteLine(" - Pandan Bua Loy Ingredients:");
										Console.WriteLine(" - 70 grams (½ cup + 2 tablespoons) sticky rice flour");
										Console.WriteLine(" - ¼ cup pandan water (plus extra, if needed)");
										Console.WriteLine(" - Coconut Soup Ingredients:");
										Console.WriteLine(" - 250 millilitres (1 cup) coconut milk");
										Console.WriteLine(" - 2 tablespoons white sugar");
										Console.WriteLine(" - 1 tablespoon palm sugar");
										Console.WriteLine(" - ¼ teaspoon salt");
										Console.WriteLine(" - 1 pandan leaf, knotted");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							case 3:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Hopia (Monggo):");
										Console.WriteLine(" - 1 Cup monggo beans use red beans");
										Console.WriteLine(" - 3/4 Cup sugar");
										Console.WriteLine(" - 1/4 Cup sweetened condensed milk");
										Console.WriteLine(" - 1/4 Cup all-purpose flour");
										Console.WriteLine(" - 1 Cup all-purpose flour for Dough 1");
										Console.WriteLine(" - 1 tablespoon sugar dissolved in 1/4 cup water, for Dough 1");
										Console.WriteLine(" - 1/4 Cup Shortening or lard, for Dough 1");
										Console.WriteLine(" - 1/8 teaspoon Salt or a pinch, for Dough 1");
										Console.WriteLine(" - 1/2 Cup all-purpose flour for Dough 2");
										Console.WriteLine(" - 1/4 Cup Shortening or lard, for Dough 2");
										Console.WriteLine(" - 1 medium Egg diluted with 1/4 cup water for egg wash");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Buko Pie:");
										Console.WriteLine(" - 2 cups all-purpose flour");
										Console.WriteLine(" - 1/3 cup butter");
										Console.WriteLine(" - 1 teaspoon salt");
										Console.WriteLine(" - 1/3 cup vegetable shortening");
										Console.WriteLine(" - 6 to 8 tablespoons cold water");
										Console.WriteLine(" - 2 cups young coconut meat");
										Console.WriteLine(" - 3/4 cup granulated white sugar");
										Console.WriteLine(" - 1/2 cup cornstarch diluted in 1/2 cup young coconut water");
										Console.WriteLine(" - 1/2 cup evaporated milk");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Ensaymada:");
										Console.WriteLine(" - Buns:");
										Console.WriteLine(" - 245ml of milk");
										Console.WriteLine(" - 100g of shortening, at room temperature");
										Console.WriteLine(" - 100g of sugar");
										Console.WriteLine(" - ¼ tbsp of salt");
										Console.WriteLine(" - 440g of flour");
										Console.WriteLine(" - 10g of active dry yeast, proofed in 60ml of warm water");
										Console.WriteLine(" - 3 egg yolks");
										Console.WriteLine(" - 60g of butter, at room temperature");
										Console.WriteLine(" - Toppings:");
										Console.WriteLine(" - 110g of butter, at room temperature");
										Console.WriteLine(" - 60g of powdered sugar");
										Console.WriteLine(" - 110g of cheese, grated");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							default:
								Console.WriteLine("Invalid choice");
								break;
						}
						break;
					case 2:
						switch (chosen)
						{
							case 1:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Almond Bear Claw:");
										Console.WriteLine(" - 1-1/2 cups cold butter, cut into 1/2-inch pieces");
										Console.WriteLine(" - 5 cups all-purpose flour, divided");
										Console.WriteLine(" - 1 package (1/4 ounce) active dry yeast");
										Console.WriteLine(" - 1-1/4 cups half-and-half cream");
										Console.WriteLine(" - 1/4 cup sugar");
										Console.WriteLine(" - 1/4 teaspoon salt");
										Console.WriteLine(" - 2 large eggs, room temperature, divided use");
										Console.WriteLine(" - 1 large egg white, room temperature");
										Console.WriteLine(" - 3/4 cup confectioners' sugar");
										Console.WriteLine(" - 1/2 cup almond paste, cubed");
										Console.WriteLine(" - 1 tablespoon water");
										Console.WriteLine(" - Sugar or coarse sugar");
										Console.WriteLine(" - Sliced almonds");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Cronut:");
										Console.WriteLine(" - Pastry Dough:");
										Console.WriteLine(" - 525 grams Bread Flour");
										Console.WriteLine(" - 6 grams kosher salt");
										Console.WriteLine(" - 64 grams granulated sugar");
										Console.WriteLine(" - 11 grams instant yeast");
										Console.WriteLine(" - 250 grams water cold");
										Console.WriteLine(" - 1 large egg white");
										Console.WriteLine(" - 112 grams unsalted butter");
										Console.WriteLine(" - 15 grams heavy cream");
										Console.WriteLine(" - Butter Block:");
										Console.WriteLine(" - 251 grams unsalted butter");
										Console.WriteLine(" - Champagne Chocolate Ganache:");
										Console.WriteLine(" - 26 grams water");
										Console.WriteLine(" - 102 grams champagne");
										Console.WriteLine(" - 9 grams unsweetened cocoa powder");
										Console.WriteLine(" - 115 grams heavy cream");
										Console.WriteLine(" - 3 large egg yolks");
										Console.WriteLine(" - 38 grams granulated sugar");
										Console.WriteLine(" - 165 grams dark chocolate 66% cocoa");
										Console.WriteLine(" - Champagne Chocolate Glaze:");
										Console.WriteLine(" - 200 grams glazing fondant");
										Console.WriteLine(" - 50 grams champagne chocolate ganache");
										Console.WriteLine(" - Vanilla Sugar:");
										Console.WriteLine(" - 205 Grams granulated sugar");
										Console.WriteLine(" - 1 vanilla bean");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Malasadas:");
										Console.WriteLine(" - 1 tablespoon active dry yeast");
										Console.WriteLine(" - 1 teaspoon granulated sugar");
										Console.WriteLine(" - 2 tablespoon water");
										Console.WriteLine(" - 3 eggs");
										Console.WriteLine(" - 1/2 cup milk");
										Console.WriteLine(" - 1/2 cup evaporated milk");
										Console.WriteLine(" - 1/2 cup granulated sugar");
										Console.WriteLine(" - 2 tablespoon unsalted butter melted");
										Console.WriteLine(" - 1/4 teaspoon salt");
										Console.WriteLine(" - 4 cups bread flour");
										Console.WriteLine(" - oil for frying");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							case 2:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Beaver Tails:");
										Console.WriteLine(" - ¾ Cup whole milk warm");
										Console.WriteLine(" - 2 ¼ Teaspoons active dry yeast");
										Console.WriteLine(" - 3 Tablespoons light brown sugar");
										Console.WriteLine(" - 2 Tablespoons canola oil");
										Console.WriteLine(" - 2 Tablespoons butter melted");
										Console.WriteLine(" - 1 Teaspoon salt");
										Console.WriteLine(" - 1 Teaspoon vanilla");
										Console.WriteLine(" - 1 egg");
										Console.WriteLine(" - 2 ¼ Cups all purpose flour");
										Console.WriteLine(" - 2 Tablespoons cinnamon");
										Console.WriteLine(" - 2 Cups granulated sugar");
										Console.WriteLine(" - canola oil for frying");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Timbits:");
										Console.WriteLine(" - 4 cups all-purpose flour , sifted");
										Console.WriteLine(" - 4 tablespoons caster sugar");
										Console.WriteLine(" - 2 tablespoons baking powder");
										Console.WriteLine(" - 1 teaspoon baking soda");
										Console.WriteLine(" - 1 teaspoon fine salt");
										Console.WriteLine(" - ½ teaspoon freshly grated nutmeg");
										Console.WriteLine(" - 2 eggs , beaten");
										Console.WriteLine(" - 300 ml whole milk or more");
										Console.WriteLine(" - 1 teaspoon vanilla extract");
										Console.WriteLine(" - 6 tablespoons unsalted butter, melted");
										Console.WriteLine(" - Vegetable oil (for frying)");
										Console.WriteLine(" - 1 cup sugar or icing sugar (for the topping)");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Blueberry Grunt:");
										Console.WriteLine(" - Filling:");
										Console.WriteLine(" - 1 cup (227g) water");
										Console.WriteLine(" - 1/2 cup to 3/4 (98g to 149g) granulated sugar");
										Console.WriteLine(" - 1 teaspoon lemon juice, if the berries aren’t tart");
										Console.WriteLine(" - 1/2 teaspoon cinnamon, optional");
										Console.WriteLine(" - 1 quart (680g) blueberries");
										Console.WriteLine(" - Dough:");
										Console.WriteLine(" - 2 cups (240g) All-Purpose Flour");
										Console.WriteLine(" - 2 teaspoons baking powder");
										Console.WriteLine(" - 1/2 teaspoon baking soda");
										Console.WriteLine(" - 1/2 teaspoon salt");
										Console.WriteLine(" - 4 tablespoons (57g) butter, cold");
										Console.WriteLine(" - 1 cup (227g) buttermilk, cold");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							case 3:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Medialunas:");
										Console.WriteLine(" - Dough:");
										Console.WriteLine(" - 300 ml. of whole milk");
										Console.WriteLine(" - 14 grams of active yeast");
										Console.WriteLine(" - 525 grams of all-purpose flour");
										Console.WriteLine(" - 40 grams of sugar");
										Console.WriteLine(" - 15 grams of honey");
										Console.WriteLine(" - 1 teaspoon of vanilla extract");
										Console.WriteLine(" - 1 teaspoon of lemon zest, optional");
										Console.WriteLine(" - 10 grams of salt");
										Console.WriteLine(" - 2 eggs (1 for the dough and 1 for the brush)");
										Console.WriteLine(" - Filling:");
										Console.WriteLine(" - 40 grams of all-purpose flour");
										Console.WriteLine(" - 225 grams of European-style butter, at room temperature");
										Console.WriteLine(" - Syrup:");
										Console.WriteLine(" - 1/2 cup of water");
										Console.WriteLine(" - 1/2 cup of sugar");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Empanadas Tucumanas:");
										Console.WriteLine(" - Flank Steak:");
										Console.WriteLine(" - 1 to 1 ¼ pounds (455 to 570 grams) flank steak");
										Console.WriteLine(" - 1 small white onion, quartered");
										Console.WriteLine(" - 1 small carrot, peeled and roughly chopped");
										Console.WriteLine(" - 1 large or 2 small bay leaves");
										Console.WriteLine(" - 2 to 3 sprigs fresh thyme");
										Console.WriteLine(" - 1 large or 3 small garlic cloves");
										Console.WriteLine(" - 10 parsley stems, broken in half (optional)");
										Console.WriteLine(" - 1 teaspoon kosher salt");
										Console.WriteLine(" - ¼ teaspoon freshly ground black pepper");
										Console.WriteLine(" - Filling:");
										Console.WriteLine(" - 2 tablespoons extra-virgin olive oil");
										Console.WriteLine(" - 1 ½ cups finely chopped white onions");
										Console.WriteLine(" - 2 tablespoons sweet Spanish paprika");
										Console.WriteLine(" - 2 ½ teaspoons kosher salt");
										Console.WriteLine(" - 2 teaspoons ground cumin");
										Console.WriteLine(" - ½ teaspoon red pepper flakes");
										Console.WriteLine(" - ½ teaspoon freshly ground black pepper");
										Console.WriteLine(" - 1 ½ cups beef broth ");
										Console.WriteLine(" - 1 tablespoon red wine vinegar");
										Console.WriteLine(" - 3 hard-boiled eggs, peeled and finely chopped");
										Console.WriteLine(" - ¾ cup thinly sliced green onions");
										Console.WriteLine(" - Bread Dough:");
										Console.WriteLine(" - 5 ¾ cups (756 grams) all-purpose flour");
										Console.WriteLine(" - 1 ½ teaspoons kosher salt");
										Console.WriteLine(" - ½ cup melted shortening or lard");
										Console.WriteLine(" - 1 ¾ cups hot water (140°F)");
										Console.WriteLine(" - Egg wash, made with 1 beaten egg and 2 teaspoons water (optional)");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Pastelitos Criollos:");
										Console.WriteLine(" - 1 1/4 cups flour");
										Console.WriteLine(" - 1/2 teaspoon salt");
										Console.WriteLine(" - 1 teaspoon granulated sugar");
										Console.WriteLine(" - 1/2 cup (4 ounces) chilled unsalted butter");
										Console.WriteLine(" - 4 ounces chilled cream cheese");
										Console.WriteLine(" - 1/2 teaspoon pure vanilla extract");
										Console.WriteLine(" - 1/2 cup dulce de leche");
										Console.WriteLine(" - 1 teaspoon ground cinnamon");
										Console.WriteLine(" - 1/4 cup light brown sugar, packed");
										Console.WriteLine(" - 1 large egg yolk");
										Console.WriteLine(" - 1 teaspoon water");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							default:
								Console.WriteLine("Invalid choice");
								break;
						}
						break;
					case 3:
						switch (chosen)
						{
							case 1:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Genovesi:");
										Console.WriteLine(" - For the Pastry Cream:");
										Console.WriteLine(" - 2 cups milk");
										Console.WriteLine(" - strip of lemon peel");
										Console.WriteLine(" - 4 large egg yolks");
										Console.WriteLine(" - 6 tbsp. granulated sugar");
										Console.WriteLine(" - 8 tbsp. all-purpose flour");
										Console.WriteLine(" - For the Pastry:");
										Console.WriteLine(" - 1 cup unsalted butter softened");
										Console.WriteLine(" - 1/2 cup granulated sugar");
										Console.WriteLine(" - 1 large egg");
										Console.WriteLine(" - 1 tsp vanilla extract");
										Console.WriteLine(" - 1/2 tsp baking powder");
										Console.WriteLine(" - 1 pinch salt");
										Console.WriteLine(" - 2 1/2 cups all-purpose flour sifted");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Seada:");
										Console.WriteLine(" - 4 cups (500 grams) of plain flour");
										Console.WriteLine(" - 1 cup (250 milliliters) cold water, or as needed");
										Console.WriteLine(" - 4 tablespoons (50 grams) of lard or butter");
										Console.WriteLine(" - 1 pinch salt");
										Console.WriteLine(" - 10 ounces (300 grams) of a young Pecorino cheese, cut into cubes");
										Console.WriteLine(" - Zest of 2 lemons");
										Console.WriteLine(" - Olive oil for frying");
										Console.WriteLine(" - 3/4 cup (250 grams) honey");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Struffoli:");
										Console.WriteLine(" - FOR THE STRUFFOLI:");
										Console.WriteLine(" - 2 tablespoons unsalted butter");
										Console.WriteLine(" - 1 medium orange");
										Console.WriteLine(" - 1 medium lemon");
										Console.WriteLine(" - 2 cups all-purpose flour, plus more for dusting");
										Console.WriteLine(" - 3 tablespoons granulated sugar");
										Console.WriteLine(" - 1/2 teaspoon kosher salt");
										Console.WriteLine(" - 1/4 teaspoon baking powder");
										Console.WriteLine(" - 3 large eggs");
										Console.WriteLine(" - 1 teaspoon vanilla extract");
										Console.WriteLine(" - 3 cups canola oil, for deep-frying");
										Console.WriteLine(" - FOR ASSEMBLY:");
										Console.WriteLine(" - 3/4 cup honey");
										Console.WriteLine(" - 1 tablespoon freshly squeezed orange juice");
										Console.WriteLine(" - Cooking spray");
										Console.WriteLine(" - Sugar sprinkles");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							case 2:
								switch (foodChoice)
								{
									case 1:
										Console.WriteLine("\nIngredients for Dariole:");
										Console.WriteLine(" - For the Sponge:");
										Console.WriteLine(" - 100 g butter unsalted, softened");
										Console.WriteLine(" - 100 g sugar caster");
										Console.WriteLine(" - 100 g self-raising flour");
										Console.WriteLine(" - 2 large eggs");
										Console.WriteLine(" - 1 tsp baking powder");
										Console.WriteLine(" - 1 tsp vanilla extract");
										Console.WriteLine(" - For the Coating:");
										Console.WriteLine(" - 100 g Red Jam");
										Console.WriteLine(" - 75 g desiccated coconut");
										Console.WriteLine(" - 4 glacé cherries halved");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Rissole:");
										Console.WriteLine(" - 1 small brown onion");
										Console.WriteLine(" - 1/2 cup panko breadcrumbs (or normal)");
										Console.WriteLine(" - 500 g / 1 lb beef mince (ground beef)");
										Console.WriteLine(" - 1 small zucchini");
										Console.WriteLine(" - 1 small carrot");
										Console.WriteLine(" - 1 egg");
										Console.WriteLine(" - 1 large garlic clove, minced");
										Console.WriteLine(" - 1/2 tsp dried thyme");
										Console.WriteLine(" - 1/2 tsp oregano");
										Console.WriteLine(" - 1/2 tsp each salt and pepper");
										Console.WriteLine(" - 2 tsp Worcestershire Sauce");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Flan Pâtissier:");
										Console.WriteLine(" - CREME PATISSIERE:");
										Console.WriteLine(" - 1 quart milk, full fat");
										Console.WriteLine(" - 2 vanilla beans , seeds scraped, beans reserved");
										Console.WriteLine(" - 1 cup caster sugar , separated");
										Console.WriteLine(" - 120g / 4.2 oz egg yolks");
										Console.WriteLine(" - 1 large egg (55 – 60g / 2 oz)");
										Console.WriteLine(" - 7 tbsp (70g) cornflour/cornstarch");
										Console.WriteLine(" - 50g (5 tbsp) unsalted butter , cut into 1cm cubes (cold)");
										Console.WriteLine(" - PASTRY:");
										Console.WriteLine(" - 2 sheets butter puff pastry, frozen");
										Console.WriteLine(" - 1 egg yolk , whisked");
										Console.WriteLine(" - Butter , for greasing");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							case 3:
								switch (foodChoice)
				         		{
									case 1:
										Console.WriteLine("\nIngredients for Kalitsounia:");
										Console.WriteLine(" - 1 beaten egg for filling");
										Console.WriteLine(" - 4 oz feta cheese crumbled");
										Console.WriteLine(" - 1 tbsp parsley finely chopped");
										Console.WriteLine(" - 1 pkg pie crusts, 2 count");
										Console.WriteLine(" - 1 beaten egg to brush tops of kalitsounia");
										Console.WriteLine(" - sesame seeds to sprinkle on top of kalitsounia");
										break;
									case 2:
										Console.WriteLine("\nIngredients for Diples:");
										Console.WriteLine(" - For the Diples:");
										Console.WriteLine(" - 2 flat tbsps sugar");
										Console.WriteLine(" - 2 flat tbsps baking soda");
										Console.WriteLine(" - 350–400g all-purpose flour (12–14 ounces)");
										Console.WriteLine(" - 5 eggs (divided into yolks and whites)");
										Console.WriteLine(" - juice of 1 lemon");
										Console.WriteLine(" - juice of 1 orange");
										Console.WriteLine(" - 1 tbsp white wine vinegar");
										Console.WriteLine(" - 1/2 cup corn oil");
										Console.WriteLine(" - a pinch of salt");
										Console.WriteLine(" - vegetable oil for frying");
										Console.WriteLine(" - For the Syrup:");
										Console.WriteLine(" - 1/4 of a cup sugar");
										Console.WriteLine(" - 1/4 of a cup water");
										Console.WriteLine(" - 1/2 cup honey");
										Console.WriteLine(" - juice of 1/2 lemon");
										Console.WriteLine(" - 1 cinnamon stick");
										Console.WriteLine(" - 150g chopped walnuts, for garnish");
										break;
									case 3:
										Console.WriteLine("\nIngredients for Loukoumades:");
										Console.WriteLine(" - For the Loukoumades:");
										Console.WriteLine(" - 1 cup of lukewarm water (240g /8.5 oz.)");
										Console.WriteLine(" - 1 cup of lukewarm milk (240g/ 8.5 oz.)");
										Console.WriteLine(" - 15 g active dry yeast (0.5 oz.)");
										Console.WriteLine(" - 3 and 1/4 of a cup flour (450g /16 oz.)");
										Console.WriteLine(" - 2 tbsps sugar");
										Console.WriteLine(" - 1 flat tsp salt");
										Console.WriteLine(" - 4 tbsps olive oil");
										Console.WriteLine(" - vegetable oil for frying");
										Console.WriteLine(" - To Garnish:");
										Console.WriteLine(" - 3/4 cup honey (350g/ 13 oz.)");
										Console.WriteLine(" - cinnamon powder");
										Console.WriteLine(" - chopped walnuts");
										Console.WriteLine(" - For the Chocolate Sauce:");
										Console.WriteLine(" - 200g dark chocolate, chopped (7 ounces)");
										Console.WriteLine(" - 110ml water (4 fluid ounces)");
										Console.WriteLine(" - 75g caster sugar (3 ounces)");
										break;
									default:
										Console.WriteLine("Invalid choice");
										break;
								}
								break;
							default:
								Console.WriteLine("Invalid choice");
								break;
						}
						break;
					default:
						Console.WriteLine("Invalid choice");
						break;
				}
            }
        }

        static void DisplayPlaces(List<string> places)
        {
            for (int p = 0; p < places.Count; p++)
            {
                Console.WriteLine($"{p + 1}. {places[p]}");
            }
        }

        static void DisplayCountries(List<string> countries)
        {
            for (int c = 0; c < countries.Count; c++)
            {
                Console.WriteLine($"{c + 1}. {countries[c]}");
            }
        }
    }
}





