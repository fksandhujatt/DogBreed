using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogBreed.Migrations
{
    /// <inheritdoc />
    public partial class IC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogBreeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubBreed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogBreeds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "Breed", "SubBreed" },
                values: new object[,]
                {
                    { 1, "affenpinscher", null },
                    { 2, "african", null },
                    { 3, "airedale", null },
                    { 4, "akita", null },
                    { 5, "appenzeller", null },
                    { 6, "basenji", null },
                    { 7, "beagle", null },
                    { 8, "bluetick", null },
                    { 9, "borzoi", null },
                    { 10, "bouvier", null },
                    { 11, "boxer", null },
                    { 12, "brabancon", null },
                    { 13, "briard", null },
                    { 14, "bulldog", "\r\n  boston,\r\n  french\r\n" },
                    { 15, "bullterrier", "\r\n  staffordshire\r\n" },
                    { 16, "cairn", null },
                    { 17, "chihuahua", null },
                    { 18, "chow", null },
                    { 19, "clumber", null },
                    { 20, "collie", "\r\n  border\r\n" },
                    { 21, "corgi", "\r\n  cardigan\r\n" },
                    { 22, "dachshund", null },
                    { 23, "dane", "\r\n  great\r\n" },
                    { 24, "deerhound", "\r\n  scottish\r\n" },
                    { 25, "dhole", null },
                    { 26, "dingo", null },
                    { 27, "doberman", null },
                    { 28, "elkhound", "\r\n  norwegian\r\n" },
                    { 29, "entlebucher", null },
                    { 30, "eskimo", null },
                    { 31, "germanshepherd", null },
                    { 32, "greyhound", "\r\n  italian\r\n" },
                    { 33, "groenendael", null },
                    { 34, "hound", "\r\n  Ibizan,\r\n  afghan,\r\n  basset,\r\n  blood,\r\n  english,\r\n  walker\r\n" },
                    { 35, "husky", null },
                    { 36, "keeshond", null },
                    { 37, "kelpie", null },
                    { 38, "komondor", null },
                    { 39, "kuvasz", null },
                    { 40, "labrador", null },
                    { 41, "leonberg", null },
                    { 42, "lhasa", null },
                    { 43, "malamute", null },
                    { 44, "malinois", null },
                    { 45, "maltese", null },
                    { 46, "mastiff", "\r\n  bull,\r\n  tibetan\r\n" },
                    { 47, "mexicanhairless", null },
                    { 48, "mountain", "\r\n  bernese,\r\n  swiss\r\n" },
                    { 49, "newfoundland", null },
                    { 50, "otterhound", null },
                    { 51, "papillon", null },
                    { 52, "pekinese", null },
                    { 53, "pembroke", null },
                    { 54, "pinscher", "\r\n  miniature\r\n" },
                    { 55, "pointer", "\r\n  german\r\n" },
                    { 56, "pomeranian", null },
                    { 57, "poodle", "\r\n  miniature,\r\n  standard,\r\n  toy\r\n" },
                    { 58, "pug", null },
                    { 59, "pyrenees", null },
                    { 60, "redbone", null },
                    { 61, "retriever", "\r\n  chesapeake,\r\n  curly,\r\n  flatcoated,\r\n  golden\r\n" },
                    { 62, "ridgeback", "\r\n  rhodesian\r\n" },
                    { 63, "rottweiler", null },
                    { 64, "saluki", null },
                    { 65, "samoyed", null },
                    { 66, "schipperke", null },
                    { 67, "schnauzer", "\r\n  giant,\r\n  miniature\r\n" },
                    { 68, "setter", "\r\n  english,\r\n  gordon,\r\n  irish\r\n" },
                    { 69, "sheepdog", "\r\n  english,\r\n  shetland\r\n" },
                    { 70, "shiba", null },
                    { 71, "shihtzu", null },
                    { 72, "spaniel", "\r\n  blenheim,\r\n  brittany,\r\n  cocker,\r\n  irish,\r\n  japanese,\r\n  sussex,\r\n  welsh\r\n" },
                    { 73, "springer", "\r\n  english\r\n" },
                    { 74, "stbernard", null },
                    { 75, "terrier", "\r\n  american,\r\n  australian,\r\n  bedlington,\r\n  border,\r\n  dandie,\r\n  fox,\r\n  irish,\r\n  kerryblue,\r\n  lakeland,\r\n  norfolk,\r\n  norwich,\r\n  patterdale,\r\n  scottish,\r\n  sealyham,\r\n  silky,\r\n  tibetan,\r\n  toy,\r\n  westhighland,\r\n  wheaten,\r\n  yorkshire\r\n" },
                    { 76, "vizsla", null },
                    { 77, "weimaraner", null },
                    { 78, "whippet", null },
                    { 79, "wolfhound", "\r\n  irish\r\n" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogBreeds");
        }
    }
}
