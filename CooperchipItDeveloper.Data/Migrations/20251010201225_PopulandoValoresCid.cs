using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CooperchipItDeveloper.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoValoresCid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "Cid",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CidInternalId = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(6)", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(4000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cid", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cid",
                columns: new[] { "Id", "CidInternalId", "Codigo", "Diagnostico" },
                values: new object[,]
                {
                    { new Guid("04e977f9-d929-48ae-8c8a-174ebedd2018"), 12, "A02.0", "Enterite por Salmonella" },
                    { new Guid("05068860-870a-47d4-aa8b-3dadeacae9d1"), 50, "A07", "Outras infecções intestinais parasitárias" },
                    { new Guid("0cd32d36-f908-488f-8ce8-3680be8b1d10"), 14, "A02.2", "Infecções localizadas por Salmonella" },
                    { new Guid("1163c601-6176-4cff-94c8-df32b7133393"), 29, "A04.4", "Outras infecções intestinais por Escherichia coli" },
                    { new Guid("1201f759-fea0-4c00-8bc1-fdbaa6a5bd93"), 17, "A03", "Shiguelose" },
                    { new Guid("259be86d-15af-471a-b0a8-3185d2e45917"), 42, "A05.9", "Intoxicação alimentar bacteriana não especificada" },
                    { new Guid("27124f31-61a3-4eb6-90de-feb6c504e99e"), 20, "A03.2", "Shiguelose devida a Shigella boydii" },
                    { new Guid("2b19ea6c-9f0b-47f0-b721-26fd56ff6392"), 28, "A04.3", "Infecção por Escherichia coli enterohemorrágica" },
                    { new Guid("2b4639aa-965c-48bd-89ad-b6576cf97f2d"), 38, "A05.2", "Intoxicação alimentar devida a Bacillus cereus" },
                    { new Guid("3196aaf9-775d-4950-ba9b-e7e85f5faaae"), 25, "A04.0", "Infecção por Escherichia coli enteropatogênica" },
                    { new Guid("43efb545-5cb6-4a3d-bde3-2523831ea593"), 8, "A01.2", "Febre paratifoide B" },
                    { new Guid("4722268a-8c4d-4f78-a893-8410ef231e5e"), 23, "A03.9", "Shiguelose não especificada" },
                    { new Guid("4aafa593-80fd-4265-859f-fdd7f2263070"), 9, "A01.3", "Febre paratifoide C" },
                    { new Guid("5ec71774-d5eb-4195-b314-2ea74eb651d5"), 48, "A06.4", "Amebíase ocular" },
                    { new Guid("68b54371-7379-4db5-896f-29275c064a39"), 30, "A04.5", "Enterite por Campylobacter" },
                    { new Guid("6cf3d94b-0cd8-42ee-8625-a1f4ec04b05c"), 35, "A05", "Intoxicações alimentares bacterianas" },
                    { new Guid("6df60c72-cbd6-4cbd-8fe7-53df1121c64b"), 49, "A06.9", "Amebíase não especificada" },
                    { new Guid("6f36bef2-f964-48f1-8d1f-bb832c50aeb2"), 47, "A06.3", "Amebíase cutânea" },
                    { new Guid("75ba4f4b-0a5f-4cbd-8c24-61ecb64f06f2"), 44, "A06.0", "Amebíase intestinal aguda" },
                    { new Guid("7bc11266-ad60-4a49-ad23-273b8759db49"), 19, "A03.1", "Shiguelose devida a Shigella flexneri" },
                    { new Guid("80af30d2-0c0c-4821-8aea-7b8206f282d5"), 40, "A05.4", "Intoxicação alimentar devida a Salmonella" },
                    { new Guid("88273d3c-5a17-467a-ab17-4dd041c0ee7b"), 15, "A02.8", "Outras infecções especificadas por Salmonella" },
                    { new Guid("89706d04-8bfe-4b95-9661-5ee52e7978c9"), 32, "A04.7", "Enterocolite devida a Clostridium difficile" },
                    { new Guid("8e23fa51-9415-4f87-970f-b6d6f273ab02"), 2, "A00.0", "Cólera devida a Vibrio cholerae 01, biótipo cholerae" },
                    { new Guid("8fa15878-7b22-4465-9adf-cdf1956aeac5"), 34, "A04.9", "Infecção intestinal bacteriana não especificada" },
                    { new Guid("91f4db60-9fa8-4711-a28e-36ed290205b6"), 27, "A04.2", "Infecção por Escherichia coli enteroinvasiva" },
                    { new Guid("976c360b-aa9e-4476-9f82-580479f53624"), 18, "A03.0", "Shiguelose devida a Shigella dysenteriae" },
                    { new Guid("97cadb68-1b27-4640-b1fa-23e3e34e034e"), 21, "A03.3", "Shiguelose devida a Shigella sonnei" },
                    { new Guid("a026752e-b6ac-4732-a422-e4f251318b59"), 7, "A01.1", "Febre paratifoide A" },
                    { new Guid("a0d63be6-eadd-4ff4-9665-ea2d92f2a651"), 11, "A02", "Outras infecções por Salmonella" },
                    { new Guid("a3f6b383-ac2f-4aab-8f4d-ca66a033eab8"), 36, "A05.0", "Intoxicação alimentar estafilocócica" },
                    { new Guid("a4fd0a8e-72a8-497c-8d28-6df2bf5a5763"), 1, "A00", "Cólera" },
                    { new Guid("a5cea669-6731-4e9d-8219-66ff56eccc50"), 33, "A04.8", "Outras infecções intestinais especificadas" },
                    { new Guid("a7625ac8-b6b9-49df-ad0e-bc339eb93284"), 37, "A05.1", "Intoxicação alimentar devida a Clostridium perfringens" },
                    { new Guid("a83996e9-df34-443c-b192-cde219ad4470"), 6, "A01.0", "Febre tifoide" },
                    { new Guid("ab89de9b-5055-440b-92e5-6557df5b031b"), 31, "A04.6", "Enterite devida a Yersinia enterocolitica" },
                    { new Guid("ad159c47-5f99-4148-a3c0-82fb61482d10"), 16, "A02.9", "Infecção por Salmonella não especificada" },
                    { new Guid("adc0335f-443b-4d30-9792-47fe86b09b61"), 26, "A04.1", "Infecção por Escherichia coli enterotoxigênica" },
                    { new Guid("b3bb3cb0-5b5d-4b31-9c53-b9914cbc8fe5"), 10, "A01.4", "Febre paratifoide não especificada" },
                    { new Guid("c7a518af-f21b-4578-b556-ddf1c725a3e7"), 43, "A06", "Amebíase" },
                    { new Guid("cac8c283-e1f1-4b60-bd03-89f669fccdb2"), 46, "A06.2", "Amebíase pulmonar" },
                    { new Guid("cf2bfe8b-262e-42e1-bb0d-55f0c56bd0db"), 39, "A05.3", "Intoxicação alimentar devida a Vibrio parahaemolyticus" },
                    { new Guid("d12111bb-ef55-437a-aba3-5aa43f3f91c2"), 4, "A00.9", "Cólera não especificada" },
                    { new Guid("d9ec5367-39c1-428a-b947-a6711c17751d"), 41, "A05.8", "Outras intoxicações alimentares bacterianas especificadas" },
                    { new Guid("e2a936e6-586c-458a-8574-e1127282010c"), 24, "A04", "Infecções intestinais bacterianas específicas" },
                    { new Guid("e685bc3f-fcb9-474d-b333-6f2953b7a8b9"), 5, "A01", "Febres tifoide e paratifóide" },
                    { new Guid("ee9bcd0d-19c2-4f04-ad88-26189277f26a"), 3, "A00.1", "Cólera devida a Vibrio cholerae 01, biótipo El Tor" },
                    { new Guid("f2dc51b5-edcc-4f70-8eb2-af73714c5ed5"), 13, "A02.1", "Septicemia por Salmonella" },
                    { new Guid("f4a75cbd-c39e-4b5e-a6d8-243cdd7749a9"), 45, "A06.1", "Amebíase hepática" },
                    { new Guid("fa2bbfdc-d616-482f-8a42-774616f736bc"), 22, "A03.8", "Outras shigueloses" }
                });

            migrationBuilder.InsertData(
                table: "Genericos",
                columns: new[] { "Id", "Codigo", "Nome" },
                values: new object[,]
                {
                    { new Guid("01205176-1522-4cf2-af42-c9af1ee6bb86"), 376, "Vitamina B1" },
                    { new Guid("0144f383-efbd-4b74-bda8-811086d236d7"), 385, "Zidovudina" },
                    { new Guid("04612936-669e-4e02-97cc-f537a31ff7df"), 14, "AGE" },
                    { new Guid("04d12583-f865-4846-a8a4-db3332d086e2"), 132, "Dopamina" },
                    { new Guid("05550d1a-e250-438f-9feb-fe653eb1b739"), 357, "Timolol" },
                    { new Guid("059aff41-a2d0-4666-a6f3-8217adf97122"), 59, "Bisoprolol" },
                    { new Guid("06018050-6428-4bfe-8e59-2612137dc7f5"), 257, "Cloreto de Sódio (NaCl)" },
                    { new Guid("061c3450-1c2c-47c3-a110-96fde53bcaf3"), 205, "Insulina" },
                    { new Guid("06ae9880-4b36-47fc-bd5e-de3e5794438e"), 278, "Octreotide" },
                    { new Guid("06d12978-7747-4bd7-9186-2680c03c602b"), 201, "Indinavir" },
                    { new Guid("06d3e231-ec4a-4e6c-aa70-4c25e2d11bb1"), 365, "Tricíclicos" },
                    { new Guid("0731d2af-f8fd-4e69-8636-6700749f5dd3"), 107, "Dantrolene" },
                    { new Guid("07941135-a893-4fef-810e-0a0a858b3575"), 233, "Losartana" },
                    { new Guid("079a9da5-c7f1-4bfd-b4b2-3a6f5133a95e"), 351, "Tiabendazol" },
                    { new Guid("079cbc16-b526-4220-9313-41027f5074b3"), 371, "Vasopressina" },
                    { new Guid("07b57411-e690-4dc8-a62a-b0b6ce222972"), 281, "Ondansetrona" },
                    { new Guid("07c0ef2a-bac2-4962-90c7-e377c2e8fb42"), 322, "Rifabutina" },
                    { new Guid("08966d90-1491-40cf-9a01-3f9e4c22b4f1"), 218, "Levodopa-Carbidopa (duplicado)" },
                    { new Guid("096ddd65-a21a-47c3-b2fa-1c621da53e5a"), 56, "Bicarbonato de Sódio" },
                    { new Guid("0a1f4609-da1c-4a0f-961d-7158aabe8578"), 164, "Fluoxetina" },
                    { new Guid("0a25e7f1-7ef0-4816-88eb-7b906f6de5b3"), 324, "Rifampicina-Isoniazida" },
                    { new Guid("0ac6cf69-65a5-4a6c-baf1-08b62ab26614"), 139, "Enoxaparina" },
                    { new Guid("0b1faf38-439e-41fa-9a29-321bf9ed6b60"), 166, "Fosamprenavir" },
                    { new Guid("0b67001d-d771-4209-9b29-2e5acdb93be9"), 290, "Penicilina G" },
                    { new Guid("0b9802ca-1f96-4f95-a625-480764b3a7e6"), 315, "Quinidina" },
                    { new Guid("0be518c3-2847-436c-9537-923a0c9fa5b5"), 267, "Nimodipina" },
                    { new Guid("0c5362b2-702e-4efb-b8c3-c87bf8637378"), 299, "Pitavastatina" },
                    { new Guid("0c96da97-00cc-4c32-a49a-1ee40c3ab288"), 120, "Dieta" },
                    { new Guid("0f2c9708-5b32-4c26-8c33-ee780dba8c54"), 51, "Bamifilina" },
                    { new Guid("10407705-46ed-41d2-9a38-3a1989509ec3"), 124, "Dimeticona" },
                    { new Guid("107852fa-a33b-4957-8ca1-11f38fda588c"), 178, "Glimepirida" },
                    { new Guid("10b62f9e-dd41-47fd-a3e9-6d21a451b5e7"), 276, "Ocitocina" },
                    { new Guid("11d1216d-803e-43a7-8236-20035c91c018"), 161, "Flumazenil" },
                    { new Guid("11f273ba-e7fe-4899-afb2-95f13d3a47fb"), 113, "Desmopressina" },
                    { new Guid("12b9e5dd-2a86-4d2c-94ea-ee9b2c69bcab"), 27, "Amiodarona" },
                    { new Guid("1328ec4a-5f16-4bec-8fc4-bdfda55c92b2"), 320, "Ranitidina" },
                    { new Guid("13823cf4-c3f9-4655-a3f7-88c06a638218"), 43, "Atenolol" },
                    { new Guid("13c90b5d-768f-477e-bfdb-ef6b602cfeab"), 36, "Anfotericina B" },
                    { new Guid("171dbde9-ca0d-42ba-ad0b-a7458943bb3d"), 7, "Ácido Fólico" },
                    { new Guid("176999da-47c2-4cca-9556-e42f37ec02e4"), 129, "Diuréticos de Alça" },
                    { new Guid("17f3e16e-f0b7-436b-a975-941d70eddbcc"), 52, "Benzoato de Benzila" },
                    { new Guid("19f0f1b9-73c8-45d9-9567-aeb8214a0605"), 179, "Glipizida" },
                    { new Guid("1cbb2f4c-526e-4720-9de4-027f8034370a"), 182, "Haloperidol" },
                    { new Guid("1d0ab63d-1027-41d0-b853-f3d99bb87a19"), 204, "Inibidores da Protease" },
                    { new Guid("1e754113-1e13-45be-8527-d12dcc34615b"), 135, "Drotrecogina Alfa" },
                    { new Guid("1ee31613-b9f6-4f0f-a9bb-e501c87d2212"), 181, "Gluconato de Cálcio" },
                    { new Guid("1f1fd5f2-6e23-4710-ba81-b6b3253dc29f"), 313, "Propranolol" },
                    { new Guid("1f29f28d-65ab-4e81-afc5-95af7c8d850e"), 277, "Octreotida" },
                    { new Guid("1fa0a97a-1b46-4f2e-a0b5-f1790fda2362"), 58, "Bisacodil" },
                    { new Guid("20c42fc8-a5ea-4c7c-bc72-39a9e1187e04"), 137, "Efavirenz" },
                    { new Guid("2365504d-efdb-4940-88ca-e612f50e9d6a"), 116, "Dexmedetomidina" },
                    { new Guid("2655a96f-c8f5-410c-bc84-ba3a3e2de747"), 372, "Vecurônio" },
                    { new Guid("26cf88df-f2fc-43c9-83c7-2abdbefed280"), 384, "Varfarina" },
                    { new Guid("26e83c8d-58a3-4dff-b688-1a15c89f0336"), 236, "Mebendazol" },
                    { new Guid("27ef2934-4d84-48ec-8839-71270f0cf5f9"), 367, "Troglitazona" },
                    { new Guid("28cee22d-fc10-402d-a507-a14d1d34c0b2"), 63, "Buspirona" },
                    { new Guid("28e571b5-a35a-4550-8087-7c99c8a37255"), 47, "Atropina" },
                    { new Guid("28fc4d8f-2402-4567-bf21-0f61d46f2a50"), 249, "Metronidazol" },
                    { new Guid("29223a3e-74b2-47b1-88b3-c15c545b07f7"), 273, "Norfloxacina" },
                    { new Guid("2987a394-6163-4a36-9874-0e84bcabf13d"), 195, "Hisoscel" },
                    { new Guid("2a73ac87-9758-4a2d-89ec-d610e85cd5e1"), 33, "Amprenavir" },
                    { new Guid("2b411a4e-f908-4886-a05e-b36a6bbf1af5"), 86, "Cinarizina" },
                    { new Guid("2bf4a1e2-f121-4e11-b601-472047c7d72c"), 91, "Clindamicina" },
                    { new Guid("2c21a27b-153f-41b3-aee8-2af5738a9286"), 127, "Dipirona" },
                    { new Guid("2dd4876f-51ec-4fe0-b186-69f7865a7997"), 89, "Citalopram" },
                    { new Guid("2ddac267-1bce-4917-b856-a3b86e398acc"), 61, "Bromoprida" },
                    { new Guid("2deebd07-4520-49d0-9f34-00c827266ba3"), 134, "Doxiciclina" },
                    { new Guid("2e108738-47e6-42af-8f47-fa23d3aacc62"), 341, "Succinilcolina" },
                    { new Guid("2e60cf7c-4518-421d-8a2d-baf6b2214737"), 387, "Curativo" },
                    { new Guid("2e7e4a14-1e7a-4b7c-8ccb-7f56912bd7cf"), 355, "Ticlopidina" },
                    { new Guid("2e9251bb-69b6-4981-ae91-904ac32a81ab"), 76, "Ceftazidima" },
                    { new Guid("2f63d9bd-5586-43c9-8248-a61468b20486"), 9, "Ácido Nicotínico" },
                    { new Guid("310ceb36-f675-4486-baf9-fea5a5b266dc"), 159, "Fluconazol" },
                    { new Guid("3195112f-6197-4067-bb61-7e4c08e3d30a"), 309, "Propafenona" },
                    { new Guid("3213d3dd-b064-4954-af1e-b4d9c07c7071"), 146, "Estreptomicina" },
                    { new Guid("33dd0021-9150-4e90-bb63-9ba6b27535f9"), 142, "Ertapenem" },
                    { new Guid("34a002c5-f9e1-4fd3-8481-4321d663be73"), 22, "Alteplase" },
                    { new Guid("34f53efa-37ab-4ef2-a7bc-169ce16c317c"), 328, "Ritonavir" },
                    { new Guid("35fa0e44-f36d-490c-91f9-0603857f5c4c"), 13, "Adrenalina" },
                    { new Guid("36aaf655-59c5-418c-8af3-9870ec4be40a"), 383, "Voriconazol" },
                    { new Guid("37cdf844-bf5e-4e86-beb8-af67fe620c91"), 69, "Cefadroxil" },
                    { new Guid("38ac3f52-159f-4e59-8ff1-c0793eee243d"), 190, "Hidroxizina" },
                    { new Guid("3928b4b7-5926-4ce3-97ce-96f5453403b0"), 252, "Mononitrato de Isossorbida" },
                    { new Guid("3a537fbb-6442-4cd9-8d7e-ad3425696d93"), 219, "Levofloxacina" },
                    { new Guid("3c76297e-2908-4863-9594-a47f6c77c524"), 95, "Clopidogrel" },
                    { new Guid("3ea4ed21-7b83-465b-b7b8-ff641ea64803"), 188, "Hidróxido de Alumínio" },
                    { new Guid("4171aee0-b142-4c44-bfca-c7f83cbe246f"), 24, "Ambroxol" },
                    { new Guid("418a73b5-a3da-434d-958a-464d76ac1c8f"), 200, "Indapamida" },
                    { new Guid("41d51807-ea0a-4bba-8700-0c4865b071d0"), 18, "Albumina" },
                    { new Guid("422b2482-7e87-42fb-8f1e-fa80baaa5e10"), 176, "Gliclazida" },
                    { new Guid("4232d63b-96ce-4db5-b964-6a73a058bf25"), 108, "Dapsona" },
                    { new Guid("4448994c-29de-454c-9b04-471cc18dbcd1"), 48, "Azitromicina" },
                    { new Guid("449c05a5-abfa-40cd-9232-7013861f323e"), 256, "N-Acetilcisteína" },
                    { new Guid("44f55b60-ac56-4e58-8f37-d5cfca19ccac"), 3, "Acarbose" },
                    { new Guid("45ae3b7e-b226-4030-8505-ace47da8a9a0"), 325, "Ringer Lactato" },
                    { new Guid("461411af-4469-48f9-b4f8-3f53ee8eb21b"), 83, "Ciclosporina" },
                    { new Guid("467173aa-afb7-4906-b802-ebafc1d15038"), 19, "Alfentanil" },
                    { new Guid("480c9e04-7f2f-4f3a-8ad6-4a2ed153e23a"), 111, "Delavirdina" },
                    { new Guid("4937dd4b-276e-4631-8f5f-bcc22ac78bd2"), 8, "Ácido Folínico" },
                    { new Guid("4ba11b63-f160-4e6a-bcaa-2cca9fbeaffc"), 223, "Lidocaína" },
                    { new Guid("4c9cf4ad-131d-4cc6-91d9-729b8c0b80ef"), 348, "Teicoplanina" },
                    { new Guid("4ca18b76-d77e-4792-9d56-2b9a0b3427e3"), 11, "Ácido Valpróico" },
                    { new Guid("4e3cd51d-4ec5-4101-a1cd-1b26b9f0eca8"), 165, "Fluvastatina" },
                    { new Guid("4e556c67-1cb6-4b6e-a08b-b9bb90a51f30"), 49, "Aztreonam" },
                    { new Guid("4f0ce91b-04a7-436d-aab0-1fdf5d9ef5a0"), 71, "Cefalotina" },
                    { new Guid("51014a67-facf-40cf-bfb8-cbc1b5a2b163"), 321, "Repaglinida" },
                    { new Guid("512ef85b-8fff-4c17-8b58-76da69f5017f"), 169, "Ganciclovir" },
                    { new Guid("5135827c-9c6f-4f93-bea5-a9023150a2f7"), 374, "Verapamil" },
                    { new Guid("51c8644b-b79a-48c5-9d65-15d8652a1504"), 359, "Tiopental" },
                    { new Guid("532537cf-c160-4657-a462-a40dd12b1f51"), 187, "Hidroxicloroquina" },
                    { new Guid("5497a5f1-2823-4243-8379-7f46796f7a90"), 53, "Betabloqueadores" },
                    { new Guid("551508af-bdbf-4cbe-8028-ff2bf4ec0a68"), 6, "Ácido Acetilsalicílico" },
                    { new Guid("55a23ef2-ac31-48b9-871c-228bdbbc3ad1"), 291, "Pentamidina" },
                    { new Guid("571301fb-0504-4798-904c-af754b842bff"), 60, "Bromazepam" },
                    { new Guid("586faba6-dc9c-4439-a92a-b2e36656d2a4"), 259, "Naloxona" },
                    { new Guid("58dd74b8-628d-40cb-a034-f79f14feb03f"), 141, "Eritropoietina" },
                    { new Guid("5a275467-90d8-4d44-bb0b-ae7e35c1d8b0"), 369, "Valsartana" },
                    { new Guid("5a9b6dbd-f53d-4443-b1ee-222ececcfb61"), 160, "Fludrocortisona" },
                    { new Guid("5acfdd15-93ae-4f98-b9ad-1e93f9c4c046"), 110, "Darunavir" },
                    { new Guid("5b0d515b-bf36-458c-a5dd-8fb3373d378d"), 298, "Piroxicam" },
                    { new Guid("5b0e9ede-8383-4ef9-9f71-15698843ea07"), 317, "Quinolonas" },
                    { new Guid("5c2c4179-b215-4ab1-aca3-3a97e577e37b"), 114, "Dexametasona" },
                    { new Guid("5c57c6d7-592a-4588-9e9c-ef8163e4985a"), 326, "Ringer Simples" },
                    { new Guid("5d42fd61-bcc8-47a6-b971-bd2809c26cfb"), 293, "Pentoxifilina" },
                    { new Guid("5d4aa172-58cd-4a33-8a10-b46c64bb9f62"), 337, "Sertralina" },
                    { new Guid("5d7ecf4d-e671-4875-88e1-38fe0373bb12"), 106, "Complexo B" },
                    { new Guid("5e1a3fe8-0b4c-45b2-a7c2-fd3003ac2fd8"), 174, "Glibenclamida" },
                    { new Guid("5fa135ca-3b3d-471c-9a5a-fea1100b75b9"), 65, "Carbamazepina" },
                    { new Guid("5fe4eb27-9955-4b85-8c9a-40a2870d72d0"), 225, "Lisinopril" },
                    { new Guid("60a3e71d-be95-4eec-b517-f8365417869b"), 55, "Bezafibrato" },
                    { new Guid("635cca5b-cde4-4c48-85f7-ed976326a863"), 300, "Plasma Fresco Congelado" },
                    { new Guid("6376ffab-7006-4f27-90ef-17a55d1375e9"), 175, "Glicerina" },
                    { new Guid("63d89908-9abc-4dcd-9aa6-2233303e1ede"), 100, "Clorpropamida" },
                    { new Guid("644322f9-1b7c-41ff-bab7-380da739f6ce"), 274, "Nortriptilina" },
                    { new Guid("6473e5d7-b120-4f65-936f-8d00672169fe"), 66, "Carvedilol" },
                    { new Guid("64af3ec6-22dc-44a4-9916-a81a2a439c3f"), 162, "Flunarizina" },
                    { new Guid("65521bd3-5808-4283-bc48-6f681ea0f4d5"), 368, "Valaciclovir" },
                    { new Guid("66f18581-8f93-40a9-b7fa-ca2f2591060a"), 286, "Pancurônio" },
                    { new Guid("67e16207-ffa9-4fb5-a861-9fa2f0803146"), 130, "Dobutamina" },
                    { new Guid("682b21b3-4903-4df6-ab9f-1e1aedef8ebd"), 194, "Hipoglicemiantes Orais" },
                    { new Guid("6a0262e9-a5bd-4958-923a-da46c924d174"), 346, "Sulfato Ferroso" },
                    { new Guid("6a0cd91d-5579-4bef-8c29-34ca6a5957d9"), 155, "Fentanil" },
                    { new Guid("6dca798d-a078-4f23-be79-2f56b732c01c"), 272, "Noradrenalina" },
                    { new Guid("6dd3b1ab-5818-4a34-bd8e-d4ca507d37e8"), 370, "Vancomicina" },
                    { new Guid("6dfa3c0d-f721-4da3-8bb7-1f50b4ead261"), 331, "Rosiglitazona" },
                    { new Guid("6e14cc89-f85e-493d-95fd-efa06875b467"), 306, "Primidona" },
                    { new Guid("6e1dc4eb-f2b7-4dcf-a0de-94dd39200719"), 97, "Clordiazepóxido" },
                    { new Guid("6e435770-e06b-444c-a779-d48e32a13011"), 269, "Nitrendipina" },
                    { new Guid("6e85a897-5095-4a4c-81f1-3d5248830401"), 62, "Bupivacaína" },
                    { new Guid("6f90f2d0-632a-4afe-97e3-59ba13eabd20"), 311, "Propiltiouracil" },
                    { new Guid("7053fca9-724c-4161-83e3-276158ad9e18"), 26, "Aminofilina" },
                    { new Guid("70767768-a2a1-436f-af08-4b8039a4f846"), 41, "Astemizol" },
                    { new Guid("707c2568-139f-4692-b519-38072e132200"), 171, "Genfibrozil" },
                    { new Guid("70a695e8-f50a-4505-9891-021609ca26b7"), 88, "Cisaprida" },
                    { new Guid("70c07d26-1295-4760-b423-240e9cd5d991"), 338, "Sildenafil" },
                    { new Guid("70e62585-5fe1-477c-a8eb-b2a92a81a4e1"), 356, "Tigeciclina" },
                    { new Guid("723aba4d-6a62-4b56-905e-ba0ef19cb77b"), 50, "Baclofeno" },
                    { new Guid("72a0e0bc-65a9-45e0-84ad-679796823a0b"), 284, "Oxacilina" },
                    { new Guid("733f0511-e988-4984-a4e0-615185be1ca4"), 228, "Lopinavir/Ritonavir" },
                    { new Guid("7486779a-4868-4c9e-a840-81ad2ee406dc"), 156, "Finasterida" },
                    { new Guid("764e071c-f885-425a-8ea8-ae861f949096"), 363, "Tramadol" },
                    { new Guid("76938932-1c91-470b-acef-f8382ed3a750"), 213, "Lamivudina" },
                    { new Guid("76c3ec27-16cd-48c1-b9d3-8ed1b066267a"), 280, "Omeprazol" },
                    { new Guid("7887614f-95dc-4037-8e1e-d708d06aa6ee"), 263, "Nevirapina" },
                    { new Guid("78ec4b23-b496-436a-95d5-e1ef9c3f91e7"), 46, "Atracúrio" },
                    { new Guid("7a0c3bee-ef92-4c7e-ab54-94e2161857a4"), 212, "Lactulose" },
                    { new Guid("7a594cec-7db9-472b-9787-6e9966cca14f"), 234, "Lovastatina" },
                    { new Guid("7ad3162d-3cc1-4a1c-b73e-b78fe4341bec"), 238, "Meperidina" },
                    { new Guid("7ad82a07-a2b4-49c1-aab1-da855f50c847"), 168, "Gabapentina" },
                    { new Guid("7b071d94-ae91-41b2-bbb4-623df63aeb3e"), 343, "Sulfametoxazol-Trimetoprim" },
                    { new Guid("7ba79579-df11-462b-ad2f-22de913e32f7"), 224, "Linezolida" },
                    { new Guid("7bb399a3-30d0-4001-8e0e-8220b76617e1"), 172, "Gentamicina" },
                    { new Guid("7bc182de-bc9d-4085-be36-2f5da36e4917"), 131, "Domperidona" },
                    { new Guid("7c4ab686-ed83-4189-b67f-d82a5fd6453f"), 30, "Amoxicilina-Clavulanato" },
                    { new Guid("7c868e3f-c9eb-4fb3-9754-1d0fca39411c"), 360, "Tipranavir" },
                    { new Guid("7d92c9c0-c802-4188-a589-179f1ab2ac9f"), 333, "rtPA" },
                    { new Guid("7f2215e0-52b0-4e1e-844c-6797c8382119"), 183, "Heparina" },
                    { new Guid("7fc535b9-7710-4f27-b536-1abe732d4526"), 144, "Espironolactona" },
                    { new Guid("8135c27f-51ac-4f36-b8e2-ce3ff8f6a477"), 35, "Anestésicos Gerais" },
                    { new Guid("82b6296d-4ec3-4e03-b0b4-5673a02a33ff"), 366, "Trimetazidina" },
                    { new Guid("83db8470-1de3-4dd1-b2b8-d0264a5d3f01"), 101, "Clortalidona" },
                    { new Guid("844ea599-90b3-4a9d-b484-e36a8a82dae6"), 304, "Prednisolona" },
                    { new Guid("84928316-3f92-43b4-b0f9-40536359f7ee"), 288, "Paracetamol" },
                    { new Guid("852e0908-8ae7-490a-b3ec-f348c99d9437"), 381, "Vitamina E" },
                    { new Guid("860e90f4-3298-4c24-8464-429b92c97b25"), 20, "Alopurinol" },
                    { new Guid("872666c9-2515-4560-9fe4-8f51829f9901"), 226, "Lítio" },
                    { new Guid("8821d030-fc34-4785-9129-5528649e0d23"), 99, "Clorpromazina" },
                    { new Guid("885f0844-91f4-4c19-8384-9c1286c5914a"), 12, "Adenosina" },
                    { new Guid("898bcddc-4249-4771-a260-3b1866df3c34"), 196, "Hypericum Perforatum" },
                    { new Guid("8a39ab7c-ff41-4f5a-8688-b49b5ff707a8"), 318, "Quinupristina-Dalfopristina" },
                    { new Guid("8bd5be45-e8d7-4706-8516-30ef61655d89"), 54, "Betametasona" },
                    { new Guid("8d0afad7-4b51-4145-a863-f0265023d7dd"), 378, "Vitamina B6" },
                    { new Guid("8d1bb090-23a1-4a0f-afaa-ffedef589362"), 221, "Levosimendan" },
                    { new Guid("8d95d744-3283-49f3-961f-12d3a23ce28e"), 335, "Saquinavir" },
                    { new Guid("8da432b0-8a4b-44c8-b23e-23d2943a1e65"), 232, "Lorazepan" },
                    { new Guid("8dd6b88f-1b92-4764-8b8e-279740ef22ee"), 186, "Hidrocortisona" },
                    { new Guid("8e8a9de2-57e5-472b-82d3-9f43cfebace1"), 258, "Nalbufina" },
                    { new Guid("8e92d01e-55b2-417f-80be-c5e1b8e20883"), 152, "Fenitoína" },
                    { new Guid("8fe615f6-dffa-43e0-9347-433d60f7fc7c"), 57, "Biperideno" },
                    { new Guid("900c2974-ec5f-42d4-87e0-e0c5c73a115f"), 302, "Posaconazol" },
                    { new Guid("909c7486-b03e-4e66-8077-9b2f9635c97f"), 373, "Venlafaxina" },
                    { new Guid("90fa91db-bc1e-4f33-af69-4836d9ce8d3e"), 199, "Imipramina" },
                    { new Guid("914ce5b2-5c8a-4ad9-a0ce-899b190341f7"), 149, "Etionamida" },
                    { new Guid("91ee6c97-1cbe-4805-bdfd-b35f9222186b"), 23, "Amantadina" },
                    { new Guid("924edb1f-9e27-47a8-93fb-5a6c85c2b64a"), 345, "Sulfato de Magnésio" },
                    { new Guid("94758cfa-dd7b-4b4c-93c1-1f86d0963068"), 203, "Inibidores da Anidrase Carbônica" },
                    { new Guid("9510b9ca-fb95-4541-af1f-0b450f6be6ce"), 211, "Labetalol" },
                    { new Guid("954da5c1-0151-4ebd-b014-434552c14c14"), 386, "RIPE" },
                    { new Guid("95778f10-871e-4b27-93b6-67ff4e589fac"), 31, "Ampicilina" },
                    { new Guid("97b61200-a8e4-4352-ac6e-732fde36ff34"), 332, "Rosuvastatina" },
                    { new Guid("97f7f3ad-0d82-481e-a9b3-483e3fdae2a0"), 350, "Terfenadina" },
                    { new Guid("98c5253a-46f0-4ec3-94a1-bf6968632a3c"), 244, "Metilprednisolona" },
                    { new Guid("998ac1b2-5136-4755-83eb-c71892ec31e0"), 73, "Cefepima" },
                    { new Guid("99ba9f70-5bb9-4644-af6f-f6b1aacf3802"), 207, "Itraconazol" },
                    { new Guid("9a0078de-b7f4-4b39-8d18-771c6bb0d348"), 237, "Mefloquina" },
                    { new Guid("9a1569b9-ab09-446e-b2df-9af69d370f00"), 294, "Piperacilina-Tazobactam" },
                    { new Guid("9abc4fbb-61aa-4b51-97eb-a7eff0708491"), 44, "Atorvastatina" },
                    { new Guid("9b2158a0-5264-42db-8888-fff5803fec65"), 217, "Levodopa-Carbidopa" },
                    { new Guid("9db7d900-df98-4ee1-88bb-4f742ecd57c0"), 220, "Levomepromazina" },
                    { new Guid("9e004067-5bb2-4c20-b27e-e65cf1021ed1"), 287, "Pantoprazol" },
                    { new Guid("9efff7c7-83e4-4d94-bacb-760f70469321"), 248, "Metotrexato" },
                    { new Guid("a1f0f25e-7997-4484-802c-a465ca071806"), 208, "Ivermectina" },
                    { new Guid("a2344d21-d4ae-41ae-b3c3-016726d323fb"), 180, "Glucagon" },
                    { new Guid("a2f9be43-5302-4386-a301-1198f933a2c1"), 157, "Fleet Enema" },
                    { new Guid("a353fc69-4d0d-4d72-9fc5-a1762503af10"), 87, "Ciprofloxacina" },
                    { new Guid("a3aa87c6-a5e5-4c6c-836f-0a4c2aabfa25"), 268, "Nistatina" },
                    { new Guid("a463bed8-e2f1-4888-aa8e-0e1ec2ba7f4c"), 295, "Pirazinamida" },
                    { new Guid("a4779b49-fb4b-4b77-9d64-119dfa7f8e1f"), 339, "Sinvastatina" },
                    { new Guid("a4c5ebdd-f5f9-4a30-a655-da7b81644c1b"), 74, "Cefotaxima" },
                    { new Guid("a560f74d-37ae-416a-9fc3-82076b412e3c"), 193, "Hioscina-Dipirona" },
                    { new Guid("a56f901f-9dac-4a81-b5cf-6ccce747dea7"), 215, "Lansoprazol" },
                    { new Guid("a5ac06d8-e0ec-4816-88c5-9de2aa39c215"), 255, "Mupirocina" },
                    { new Guid("a5b55dcc-3b8b-4e29-886a-8c9d706bfc26"), 282, "Orlistate" },
                    { new Guid("a6612f91-6dae-4d2a-b0d9-b1dec4b13cef"), 275, "Nutrição Parenteral Total" },
                    { new Guid("a682c1f6-8708-4cd1-929d-fd0a778147ec"), 197, "Ibuprofeno" },
                    { new Guid("a769e408-c2d4-455d-8db7-85dbe1f71c8d"), 231, "Lorazepam" },
                    { new Guid("a77f1e7f-733a-4052-a969-9993235a6b0a"), 173, "Ginkgo Biloba" },
                    { new Guid("a782c998-bc3c-434d-ad1c-655416a85463"), 354, "Ticarcilina-Clavulanato" },
                    { new Guid("a7a1cc78-155d-4a03-8c41-740371b76907"), 229, "Lopinavir-Ritonavir" },
                    { new Guid("a811565e-9dd3-4e66-8283-796e1f5ae3ae"), 42, "Atazanavir" },
                    { new Guid("a85b6f57-acfd-4670-b729-ef504865f4b0"), 307, "Procainamida" },
                    { new Guid("a86dbf89-c9c1-4c9e-b5e6-1406e18f9051"), 329, "Rivaroxabana" },
                    { new Guid("a9e1e6a6-b371-47bd-a747-501a911e0b7f"), 126, "Diosmina-Hesperidina" },
                    { new Guid("aab65e45-d601-4d17-8f5c-8b2016519f88"), 206, "Isoniazida" },
                    { new Guid("ab2d8b63-e54b-4241-bb40-e9b86c5a82f0"), 312, "Propofol" },
                    { new Guid("ab883eb2-df33-481e-a540-c16b6518698f"), 347, "Tamarine" },
                    { new Guid("ab98fa77-587f-44ee-b3fc-c7b0816acd50"), 192, "Hioscina Composta" },
                    { new Guid("abda80c8-9ad1-4d0c-8482-723200384cdf"), 270, "Nitroglicerina" },
                    { new Guid("ac073cb4-3107-4185-b5c6-5a13d6597ca4"), 303, "Pravastatina" },
                    { new Guid("ac3e85bf-c470-4f70-8538-0bc69f8c9c79"), 336, "Secnidazol" },
                    { new Guid("acb7795c-792f-4f5e-9a4f-83953f929e53"), 362, "Tobramicina" },
                    { new Guid("ad3c80c4-0699-44fe-8d84-547d76a117ff"), 202, "Indometacina" },
                    { new Guid("ad8ba056-510e-4b94-8916-d3fbaef9d483"), 17, "Albendazol" },
                    { new Guid("afac17b9-bc99-40f5-a04e-cde13a908968"), 353, "Ticarcilina" },
                    { new Guid("b10a965a-a995-49e6-90a7-e94bb3bdc932"), 133, "Doxazosina" },
                    { new Guid("b23056b9-d18e-4fe6-81b5-9798562a7925"), 119, "Didanosina" },
                    { new Guid("b2380f17-ca4b-43e4-8329-8170209a83cb"), 93, "Clonazepam" },
                    { new Guid("b33ca8d6-e9fa-45ff-9e6c-c900a718089c"), 38, "Antiarritmicos" },
                    { new Guid("b3e4f9f0-273d-4633-a504-1bc9a4309ff5"), 316, "Quinina" },
                    { new Guid("b3ec31db-c138-4550-a90e-158708196c3c"), 92, "Clofibrato" },
                    { new Guid("b4ecafd1-1829-4356-b6b2-861986c29c2a"), 147, "Estreptoquinase" },
                    { new Guid("b5a3d5b5-1322-4abf-9051-f7f5b26e71d6"), 32, "Ampicilina-Sulbactam" },
                    { new Guid("b5e92090-9beb-446d-8c5c-d943f1a10094"), 305, "Prednisona" },
                    { new Guid("b62d8c49-17b6-4543-9197-d4e7f93d72d3"), 16, "AINEs" },
                    { new Guid("b6b20700-abb0-4b72-8ca9-35e68292d285"), 262, "Neostigmina" },
                    { new Guid("b72bf90e-3013-484c-a02c-4ff0bf24da0c"), 68, "Cefaclor" },
                    { new Guid("b79c487f-ed3b-42b0-92cf-b9cb2a6047ae"), 271, "Nitroprussiato de Sódio" },
                    { new Guid("b79d03af-c039-4a67-82e1-24fa198c8556"), 352, "Tiazídicos" },
                    { new Guid("b8b0e975-2f6f-4580-abcc-8a6629cb1ecb"), 154, "Fenotiazinas" },
                    { new Guid("b8c476da-4d6b-45d2-851f-00a185499710"), 64, "Captopril" },
                    { new Guid("b9028932-c3ad-47c8-a8fa-108378fe74b6"), 37, "Anlodipina" },
                    { new Guid("b90386e0-4396-4429-bc82-98b0ab903eed"), 150, "Etoricoxibe" },
                    { new Guid("b9819a62-b240-4684-a816-cc781d2bc8d4"), 70, "Cefalexina" },
                    { new Guid("b9b1777e-64d0-4032-af0b-54450eede067"), 77, "Ceftriaxona" },
                    { new Guid("baa63f5d-b426-4cf3-8b80-e32f8eeb5321"), 151, "Fenazopiridina" },
                    { new Guid("bc07c209-7e1b-4a2d-a483-d582156afff5"), 344, "Sulfassalazina" },
                    { new Guid("bc8ab2e1-95df-41ce-925a-5eb675258b23"), 4, "Acetazolamida" },
                    { new Guid("be5cbb74-c5fd-4cb9-9864-aa31f8554612"), 292, "Pentobarbital" },
                    { new Guid("bf1edf83-c2a8-4569-a1d3-2ed01f1cdb32"), 104, "Colchicina" },
                    { new Guid("bf52e4f6-9738-48bd-8d61-a7d0e6748384"), 123, "Dimenidrinato" },
                    { new Guid("bf54d7a8-ebce-46da-8ae3-e5b650f51901"), 94, "Clonidina" },
                    { new Guid("c016da44-5f13-4341-934d-c0c154991aed"), 227, "Loperamida" },
                    { new Guid("c17b29e5-fd18-4e5e-8810-0f05202d6433"), 153, "Fenobarbital" },
                    { new Guid("c1d29cec-b38b-4f7f-9f99-dbe419b5f78e"), 327, "Risperidona" },
                    { new Guid("c20f9f5d-0e3b-47cb-b343-94145105814b"), 82, "Cetorolaco" },
                    { new Guid("c2effeab-efc3-4879-b4b3-702a3ebd2d61"), 136, "Ebastina" },
                    { new Guid("c37a5fe5-ab89-486e-a001-bdc6c8a5c889"), 319, "Ramipril" },
                    { new Guid("c4d9068b-67ce-43cb-8051-771769b853c1"), 310, "Propatilnitrato" },
                    { new Guid("c4dbb734-ee2d-4266-a02c-4a5c14319a1e"), 90, "Claritromicina" },
                    { new Guid("c624e167-965c-4deb-a2c9-f2b5038853f4"), 115, "Dexclorfeniramina" },
                    { new Guid("c62a4f5a-2dfa-445b-98f8-aa6bbd223896"), 314, "Protamina" },
                    { new Guid("c6a8acfe-1738-4dce-a19a-78f4fed49a01"), 296, "Piridostigmina" },
                    { new Guid("c6d72436-4607-4cd6-87e5-8376d25ccc93"), 15, "Água" },
                    { new Guid("c7388f65-41bd-4c7e-aa7b-87ab1f67a788"), 125, "Dinitrato de Isossorbida" },
                    { new Guid("c81e0188-cff8-40c3-b76a-cefd0d8be248"), 189, "Hidroxietilamido" },
                    { new Guid("c87d376d-7607-4b6e-81e4-289cd52a72ae"), 67, "Caspofungina" },
                    { new Guid("c88a82d4-52bb-438c-82fc-228460838f1d"), 235, "Manitol" },
                    { new Guid("c8ef303f-cf6e-4134-8e2a-c935cccc157a"), 143, "Esmolol" },
                    { new Guid("c9d9183e-4121-4340-a264-9e68a5b84fbb"), 170, "Gatifloxacina" },
                    { new Guid("c9e2ef41-fddf-40bb-9d22-fb68d1d3d156"), 102, "Codeína" },
                    { new Guid("ca45c31d-0cc3-4ff5-b2dc-333e5a94d41a"), 253, "Morfina" },
                    { new Guid("cac5502d-c6b0-4ebc-9fa9-f70f04ea201c"), 230, "Loratadina" },
                    { new Guid("cbd671e7-3e4f-4cb1-9127-75d82edac9d3"), 138, "Enalapril" },
                    { new Guid("cbf0cd99-bb88-41fe-88ba-c8239dd3823a"), 209, "Cloreto de Potássio (KCl)" },
                    { new Guid("cbfb1eeb-6e40-4a1b-afdd-3087090ce367"), 84, "Cilostazol" },
                    { new Guid("cc524c54-59cb-4d01-b30f-072b55db2b46"), 45, "Atovaquona" },
                    { new Guid("cd00e612-dbc2-4530-81b8-6e38ac615b1f"), 167, "Furosemida" },
                    { new Guid("cd197c07-0881-4857-a58f-8b02a0267b3d"), 2, "Abciximab" },
                    { new Guid("cd55e48b-514d-45de-ba89-f5e278988235"), 279, "Óleo Mineral" },
                    { new Guid("cd7bd2ff-69f1-4091-8790-c0c9088f05ea"), 358, "Tinidazol" },
                    { new Guid("cdc1eeda-432e-47ef-a1ae-898cdb13ad2a"), 265, "Nifepidina" },
                    { new Guid("cdd7e2d0-72ff-4860-a234-224c60a4e305"), 109, "Daptomicina" },
                    { new Guid("cf23ed30-9417-47c3-82e4-ed83ef4fe029"), 1, "Abacavir" },
                    { new Guid("cf870238-c564-4624-8402-1cd47203aa37"), 243, "Metildopa" },
                    { new Guid("d0c149fc-eb69-4be5-a492-a6141581e597"), 5, "Aciclovir" },
                    { new Guid("d1645530-3955-4d3d-b87d-e64f2a92a35a"), 177, "Glicose" },
                    { new Guid("d18ec693-9d92-466f-8648-29547fe56e2c"), 140, "Eritromicina" },
                    { new Guid("d1b2f230-2cbb-41fc-99be-2bc8b69f7657"), 285, "Oxigênio" },
                    { new Guid("d1bd0a14-9f41-4b48-84e0-496582f28af0"), 301, "Polimixina B" },
                    { new Guid("d2045565-d098-42ea-9da8-1a057bceb015"), 145, "Estavudina" },
                    { new Guid("d3a4836e-d09d-4f6d-8c70-af0e692aec44"), 34, "Amrinona" },
                    { new Guid("d5868211-e33f-4200-ac7a-d2e17be107ae"), 264, "Nifedipina" },
                    { new Guid("d5c2cda9-c8c6-49e0-aeb2-e8f1791ce910"), 198, "Imipenem" },
                    { new Guid("d5c78913-6713-48b2-94cb-107bc97482b8"), 210, "Cetamina" },
                    { new Guid("d6395d36-8bb6-4015-94e2-296b47508e9c"), 261, "Nelfinavir" },
                    { new Guid("d6cc9bdf-159c-4f54-9376-2118727ed5e9"), 185, "Hidroclorotiazida" },
                    { new Guid("d8b6f268-dce6-4fd9-85bc-a7cf52861d36"), 375, "Verapamil (duplicado)" },
                    { new Guid("da800a9b-3a44-46e1-84b3-ca38a1296e83"), 148, "Etambutol" },
                    { new Guid("dbedf850-e37b-479d-b2f5-4f5691aa8722"), 72, "Cefazolina" },
                    { new Guid("dbffadbf-0625-40e5-90fb-93f6d7c4e733"), 364, "Trazodona" },
                    { new Guid("dc3cbbe6-67cc-436c-9291-87f08f6e53bb"), 40, "Antipsicóticos" },
                    { new Guid("de32755f-d89d-4e4d-bbc3-8376c4f69d4a"), 382, "Vitamina K" },
                    { new Guid("de83a032-d750-4905-96b7-52fb93389d8a"), 105, "Colestiramina" },
                    { new Guid("df1eba44-ae33-44d8-89c0-d364ebfe8653"), 191, "Hioscina" },
                    { new Guid("df9ac075-8d21-4606-91a7-b2ea04c5ca89"), 334, "Salbutamol" },
                    { new Guid("dfe471c3-2e52-4580-a96b-d6dcd33d381b"), 80, "Cetoconazol" },
                    { new Guid("e07fb8ef-9647-44d5-bc83-d6450d57767d"), 251, "Milrinona" },
                    { new Guid("e0ceb5f6-42cc-4c8f-819c-fcd4524c3011"), 239, "Meropenem" },
                    { new Guid("e0db050b-4fd8-476c-b917-ac12ebf21b09"), 96, "Cloranfenicol" },
                    { new Guid("e129baf9-0b0f-4e3b-b39b-4436ca13c2f5"), 122, "Diltiazem" },
                    { new Guid("e19297fa-7fe3-4e49-8829-ed5a92df80ac"), 117, "Diazepam" },
                    { new Guid("e234baf8-80a6-4a65-8e00-99987592679a"), 246, "Metoclopramida" },
                    { new Guid("e295e503-083e-4077-9e2a-30c1c49be37b"), 222, "Levotiroxina" },
                    { new Guid("e2ff5983-de6d-4a79-9eb8-cea0c5d96198"), 380, "Vitamina D" },
                    { new Guid("e380cc55-a296-4e66-8d1c-410798cf719b"), 75, "Cefpiroma" },
                    { new Guid("e3b22bb4-7432-473f-bafb-113b44dd7164"), 379, "Vitamina C" },
                    { new Guid("e3ed4391-ebbd-429c-acff-abc3b37c267c"), 349, "Tenoxicam" },
                    { new Guid("e4a6653b-a3db-457f-8f3b-1aee3e2332f9"), 103, "Codergocrina" },
                    { new Guid("e538aa57-97d0-4ef0-801e-ebaaee5af28e"), 240, "Mesalazina" },
                    { new Guid("e654914c-a3a6-49bc-94cb-f5bfe23cdd65"), 10, "Ácido Tranexâmico" },
                    { new Guid("e6869171-7778-49a1-8b55-6057a65eb36b"), 283, "Oseltamivir" },
                    { new Guid("e7118113-d4b4-4877-afe2-f747d6d7181e"), 330, "Rivastigmina" },
                    { new Guid("e7429d8f-955f-4e1d-a871-2d6a13b7055c"), 361, "Tirofiban" },
                    { new Guid("e7d244cb-e09c-4785-9438-436745d2839b"), 242, "Metformina" },
                    { new Guid("e8ced2f7-5e9d-43f9-8335-3ad6b7cdc777"), 340, "Sotalol" },
                    { new Guid("e9742b10-4a8e-4fb9-9d13-0e65ce914440"), 308, "Prometazina" },
                    { new Guid("e98aa049-2f42-4dc3-87af-89943d85e2f6"), 342, "Sucralfato" },
                    { new Guid("ea74cf25-3d71-4a13-bc9b-39ca0bcf440c"), 184, "Hidralazina" },
                    { new Guid("ea86ce25-b72f-4535-aa24-269d94d78f2c"), 241, "Metadona" },
                    { new Guid("ea8f12e6-bc21-45f1-a708-c7e285f0c21d"), 79, "Celecoxibe" },
                    { new Guid("eaafc09b-eeb7-4d79-9463-55a7c31857d0"), 78, "Cefuroxima" },
                    { new Guid("ebf71930-3d56-480b-b364-f3bac65dcf71"), 81, "Cetoprofeno" },
                    { new Guid("ec0b8c56-de53-4303-b24a-0e70fcc809f0"), 128, "Disopiramida" },
                    { new Guid("ec2989e1-f244-491b-8982-f1a1583180eb"), 214, "Lamivudina-Zidovudina" },
                    { new Guid("ec3184b7-f7e3-46f9-8b6a-02bdbf0d1fcf"), 28, "Amitriptilina" },
                    { new Guid("ecb6fb69-e422-415b-8b5e-f95d0110e94f"), 260, "Nebivolol" },
                    { new Guid("eeca379a-cc92-489b-86aa-40b7363096e5"), 118, "Diclofenaco" },
                    { new Guid("ef138256-676c-4f00-9cc1-de78f55cb2f2"), 98, "Cloroquina" },
                    { new Guid("f03439a4-cf8f-42dc-869f-83e3e4f162eb"), 250, "Midazolam" },
                    { new Guid("f1495025-25cc-48a0-a515-cf0482459a67"), 163, "Flunitrazepam" },
                    { new Guid("f2686468-a1d6-47e0-a0e3-51e6975b2c48"), 112, "Deslanosídeo C" },
                    { new Guid("f3aafc7b-8c7c-4966-91b4-21a987fd6983"), 377, "Vitamina B12" },
                    { new Guid("f3ca07d3-8101-45db-ba9f-8e0b5e10e883"), 39, "Antiparkinsonianos" },
                    { new Guid("f7906035-d01d-4b6d-a687-5de0d60c041b"), 85, "Cimetidina" },
                    { new Guid("f7d1e54a-36ee-4c45-a090-069d1b0b5d6c"), 289, "Paroxetina" },
                    { new Guid("f8101024-8b87-4ee3-9ef0-fd075a5aae88"), 29, "Amoxicilina" },
                    { new Guid("f856272a-e476-4c38-b632-3876ab83929f"), 158, "Floratil" },
                    { new Guid("f8ce794f-fa3d-46e1-b536-67d48dab2698"), 121, "Digoxina" },
                    { new Guid("f9aa1961-b3da-499f-b095-fdbe70d3cfd9"), 245, "Metimazol" },
                    { new Guid("fb1f0f1d-c2eb-4050-bad4-60604811db7b"), 25, "Amicacina" },
                    { new Guid("fbd51f4c-98ba-43e6-a071-6b1720b7ce18"), 323, "Rifampicina" },
                    { new Guid("fc16ca74-7e61-49d2-96ff-b6ba3e252add"), 297, "Pirimetamina" },
                    { new Guid("fc2e0f24-ac1c-4ddc-8274-60e0262b7dbb"), 254, "Moxifloxacina" },
                    { new Guid("fd7c3e78-8853-427d-89a2-f2714962d6e7"), 247, "Metoprolol" },
                    { new Guid("fe35a8f0-53e6-4244-bbae-921d4a9f03ea"), 216, "Levodopa" },
                    { new Guid("fe47cf84-02b5-435e-9d73-467a3938a31c"), 266, "Nimesulida" },
                    { new Guid("ff9ab922-1f49-4d81-96eb-64653bcb532a"), 21, "Alprazolam" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cid");

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("01205176-1522-4cf2-af42-c9af1ee6bb86"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0144f383-efbd-4b74-bda8-811086d236d7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("04612936-669e-4e02-97cc-f537a31ff7df"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("04d12583-f865-4846-a8a4-db3332d086e2"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("05550d1a-e250-438f-9feb-fe653eb1b739"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("059aff41-a2d0-4666-a6f3-8217adf97122"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("06018050-6428-4bfe-8e59-2612137dc7f5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("061c3450-1c2c-47c3-a110-96fde53bcaf3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("06ae9880-4b36-47fc-bd5e-de3e5794438e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("06d12978-7747-4bd7-9186-2680c03c602b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("06d3e231-ec4a-4e6c-aa70-4c25e2d11bb1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0731d2af-f8fd-4e69-8636-6700749f5dd3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("07941135-a893-4fef-810e-0a0a858b3575"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("079a9da5-c7f1-4bfd-b4b2-3a6f5133a95e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("079cbc16-b526-4220-9313-41027f5074b3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("07b57411-e690-4dc8-a62a-b0b6ce222972"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("07c0ef2a-bac2-4962-90c7-e377c2e8fb42"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("08966d90-1491-40cf-9a01-3f9e4c22b4f1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("096ddd65-a21a-47c3-b2fa-1c621da53e5a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0a1f4609-da1c-4a0f-961d-7158aabe8578"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0a25e7f1-7ef0-4816-88eb-7b906f6de5b3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0ac6cf69-65a5-4a6c-baf1-08b62ab26614"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0b1faf38-439e-41fa-9a29-321bf9ed6b60"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0b67001d-d771-4209-9b29-2e5acdb93be9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0b9802ca-1f96-4f95-a625-480764b3a7e6"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0be518c3-2847-436c-9537-923a0c9fa5b5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0c5362b2-702e-4efb-b8c3-c87bf8637378"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0c96da97-00cc-4c32-a49a-1ee40c3ab288"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("0f2c9708-5b32-4c26-8c33-ee780dba8c54"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("10407705-46ed-41d2-9a38-3a1989509ec3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("107852fa-a33b-4957-8ca1-11f38fda588c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("10b62f9e-dd41-47fd-a3e9-6d21a451b5e7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("11d1216d-803e-43a7-8236-20035c91c018"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("11f273ba-e7fe-4899-afb2-95f13d3a47fb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("12b9e5dd-2a86-4d2c-94ea-ee9b2c69bcab"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1328ec4a-5f16-4bec-8fc4-bdfda55c92b2"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("13823cf4-c3f9-4655-a3f7-88c06a638218"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("13c90b5d-768f-477e-bfdb-ef6b602cfeab"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("171dbde9-ca0d-42ba-ad0b-a7458943bb3d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("176999da-47c2-4cca-9556-e42f37ec02e4"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("17f3e16e-f0b7-436b-a975-941d70eddbcc"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("19f0f1b9-73c8-45d9-9567-aeb8214a0605"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1cbb2f4c-526e-4720-9de4-027f8034370a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1d0ab63d-1027-41d0-b853-f3d99bb87a19"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1e754113-1e13-45be-8527-d12dcc34615b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1ee31613-b9f6-4f0f-a9bb-e501c87d2212"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1f1fd5f2-6e23-4710-ba81-b6b3253dc29f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1f29f28d-65ab-4e81-afc5-95af7c8d850e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("1fa0a97a-1b46-4f2e-a0b5-f1790fda2362"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("20c42fc8-a5ea-4c7c-bc72-39a9e1187e04"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2365504d-efdb-4940-88ca-e612f50e9d6a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2655a96f-c8f5-410c-bc84-ba3a3e2de747"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("26cf88df-f2fc-43c9-83c7-2abdbefed280"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("26e83c8d-58a3-4dff-b688-1a15c89f0336"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("27ef2934-4d84-48ec-8839-71270f0cf5f9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("28cee22d-fc10-402d-a507-a14d1d34c0b2"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("28e571b5-a35a-4550-8087-7c99c8a37255"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("28fc4d8f-2402-4567-bf21-0f61d46f2a50"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("29223a3e-74b2-47b1-88b3-c15c545b07f7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2987a394-6163-4a36-9874-0e84bcabf13d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2a73ac87-9758-4a2d-89ec-d610e85cd5e1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2b411a4e-f908-4886-a05e-b36a6bbf1af5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2bf4a1e2-f121-4e11-b601-472047c7d72c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2c21a27b-153f-41b3-aee8-2af5738a9286"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2dd4876f-51ec-4fe0-b186-69f7865a7997"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2ddac267-1bce-4917-b856-a3b86e398acc"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2deebd07-4520-49d0-9f34-00c827266ba3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2e108738-47e6-42af-8f47-fa23d3aacc62"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2e60cf7c-4518-421d-8a2d-baf6b2214737"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2e7e4a14-1e7a-4b7c-8ccb-7f56912bd7cf"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2e9251bb-69b6-4981-ae91-904ac32a81ab"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("2f63d9bd-5586-43c9-8248-a61468b20486"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("310ceb36-f675-4486-baf9-fea5a5b266dc"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("3195112f-6197-4067-bb61-7e4c08e3d30a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("3213d3dd-b064-4954-af1e-b4d9c07c7071"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("33dd0021-9150-4e90-bb63-9ba6b27535f9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("34a002c5-f9e1-4fd3-8481-4321d663be73"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("34f53efa-37ab-4ef2-a7bc-169ce16c317c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("35fa0e44-f36d-490c-91f9-0603857f5c4c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("36aaf655-59c5-418c-8af3-9870ec4be40a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("37cdf844-bf5e-4e86-beb8-af67fe620c91"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("38ac3f52-159f-4e59-8ff1-c0793eee243d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("3928b4b7-5926-4ce3-97ce-96f5453403b0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("3a537fbb-6442-4cd9-8d7e-ad3425696d93"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("3c76297e-2908-4863-9594-a47f6c77c524"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("3ea4ed21-7b83-465b-b7b8-ff641ea64803"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4171aee0-b142-4c44-bfca-c7f83cbe246f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("418a73b5-a3da-434d-958a-464d76ac1c8f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("41d51807-ea0a-4bba-8700-0c4865b071d0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("422b2482-7e87-42fb-8f1e-fa80baaa5e10"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4232d63b-96ce-4db5-b964-6a73a058bf25"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4448994c-29de-454c-9b04-471cc18dbcd1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("449c05a5-abfa-40cd-9232-7013861f323e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("44f55b60-ac56-4e58-8f37-d5cfca19ccac"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("45ae3b7e-b226-4030-8505-ace47da8a9a0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("461411af-4469-48f9-b4f8-3f53ee8eb21b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("467173aa-afb7-4906-b802-ebafc1d15038"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("480c9e04-7f2f-4f3a-8ad6-4a2ed153e23a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4937dd4b-276e-4631-8f5f-bcc22ac78bd2"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4ba11b63-f160-4e6a-bcaa-2cca9fbeaffc"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4c9cf4ad-131d-4cc6-91d9-729b8c0b80ef"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4ca18b76-d77e-4792-9d56-2b9a0b3427e3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4e3cd51d-4ec5-4101-a1cd-1b26b9f0eca8"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4e556c67-1cb6-4b6e-a08b-b9bb90a51f30"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("4f0ce91b-04a7-436d-aab0-1fdf5d9ef5a0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("51014a67-facf-40cf-bfb8-cbc1b5a2b163"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("512ef85b-8fff-4c17-8b58-76da69f5017f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5135827c-9c6f-4f93-bea5-a9023150a2f7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("51c8644b-b79a-48c5-9d65-15d8652a1504"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("532537cf-c160-4657-a462-a40dd12b1f51"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5497a5f1-2823-4243-8379-7f46796f7a90"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("551508af-bdbf-4cbe-8028-ff2bf4ec0a68"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("55a23ef2-ac31-48b9-871c-228bdbbc3ad1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("571301fb-0504-4798-904c-af754b842bff"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("586faba6-dc9c-4439-a92a-b2e36656d2a4"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("58dd74b8-628d-40cb-a034-f79f14feb03f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5a275467-90d8-4d44-bb0b-ae7e35c1d8b0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5a9b6dbd-f53d-4443-b1ee-222ececcfb61"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5acfdd15-93ae-4f98-b9ad-1e93f9c4c046"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5b0d515b-bf36-458c-a5dd-8fb3373d378d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5b0e9ede-8383-4ef9-9f71-15698843ea07"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5c2c4179-b215-4ab1-aca3-3a97e577e37b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5c57c6d7-592a-4588-9e9c-ef8163e4985a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5d42fd61-bcc8-47a6-b971-bd2809c26cfb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5d4aa172-58cd-4a33-8a10-b46c64bb9f62"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5d7ecf4d-e671-4875-88e1-38fe0373bb12"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5e1a3fe8-0b4c-45b2-a7c2-fd3003ac2fd8"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5fa135ca-3b3d-471c-9a5a-fea1100b75b9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("5fe4eb27-9955-4b85-8c9a-40a2870d72d0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("60a3e71d-be95-4eec-b517-f8365417869b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("635cca5b-cde4-4c48-85f7-ed976326a863"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6376ffab-7006-4f27-90ef-17a55d1375e9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("63d89908-9abc-4dcd-9aa6-2233303e1ede"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("644322f9-1b7c-41ff-bab7-380da739f6ce"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6473e5d7-b120-4f65-936f-8d00672169fe"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("64af3ec6-22dc-44a4-9916-a81a2a439c3f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("65521bd3-5808-4283-bc48-6f681ea0f4d5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("66f18581-8f93-40a9-b7fa-ca2f2591060a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("67e16207-ffa9-4fb5-a861-9fa2f0803146"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("682b21b3-4903-4df6-ab9f-1e1aedef8ebd"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6a0262e9-a5bd-4958-923a-da46c924d174"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6a0cd91d-5579-4bef-8c29-34ca6a5957d9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6dca798d-a078-4f23-be79-2f56b732c01c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6dd3b1ab-5818-4a34-bd8e-d4ca507d37e8"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6dfa3c0d-f721-4da3-8bb7-1f50b4ead261"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6e14cc89-f85e-493d-95fd-efa06875b467"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6e1dc4eb-f2b7-4dcf-a0de-94dd39200719"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6e435770-e06b-444c-a779-d48e32a13011"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6e85a897-5095-4a4c-81f1-3d5248830401"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("6f90f2d0-632a-4afe-97e3-59ba13eabd20"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7053fca9-724c-4161-83e3-276158ad9e18"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("70767768-a2a1-436f-af08-4b8039a4f846"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("707c2568-139f-4692-b519-38072e132200"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("70a695e8-f50a-4505-9891-021609ca26b7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("70c07d26-1295-4760-b423-240e9cd5d991"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("70e62585-5fe1-477c-a8eb-b2a92a81a4e1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("723aba4d-6a62-4b56-905e-ba0ef19cb77b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("72a0e0bc-65a9-45e0-84ad-679796823a0b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("733f0511-e988-4984-a4e0-615185be1ca4"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7486779a-4868-4c9e-a840-81ad2ee406dc"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("764e071c-f885-425a-8ea8-ae861f949096"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("76938932-1c91-470b-acef-f8382ed3a750"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("76c3ec27-16cd-48c1-b9d3-8ed1b066267a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7887614f-95dc-4037-8e1e-d708d06aa6ee"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("78ec4b23-b496-436a-95d5-e1ef9c3f91e7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7a0c3bee-ef92-4c7e-ab54-94e2161857a4"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7a594cec-7db9-472b-9787-6e9966cca14f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7ad3162d-3cc1-4a1c-b73e-b78fe4341bec"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7ad82a07-a2b4-49c1-aab1-da855f50c847"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7b071d94-ae91-41b2-bbb4-623df63aeb3e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7ba79579-df11-462b-ad2f-22de913e32f7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7bb399a3-30d0-4001-8e0e-8220b76617e1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7bc182de-bc9d-4085-be36-2f5da36e4917"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7c4ab686-ed83-4189-b67f-d82a5fd6453f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7c868e3f-c9eb-4fb3-9754-1d0fca39411c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7d92c9c0-c802-4188-a589-179f1ab2ac9f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7f2215e0-52b0-4e1e-844c-6797c8382119"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("7fc535b9-7710-4f27-b536-1abe732d4526"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8135c27f-51ac-4f36-b8e2-ce3ff8f6a477"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("82b6296d-4ec3-4e03-b0b4-5673a02a33ff"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("83db8470-1de3-4dd1-b2b8-d0264a5d3f01"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("844ea599-90b3-4a9d-b484-e36a8a82dae6"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("84928316-3f92-43b4-b0f9-40536359f7ee"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("852e0908-8ae7-490a-b3ec-f348c99d9437"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("860e90f4-3298-4c24-8464-429b92c97b25"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("872666c9-2515-4560-9fe4-8f51829f9901"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8821d030-fc34-4785-9129-5528649e0d23"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("885f0844-91f4-4c19-8384-9c1286c5914a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("898bcddc-4249-4771-a260-3b1866df3c34"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8a39ab7c-ff41-4f5a-8688-b49b5ff707a8"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8bd5be45-e8d7-4706-8516-30ef61655d89"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8d0afad7-4b51-4145-a863-f0265023d7dd"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8d1bb090-23a1-4a0f-afaa-ffedef589362"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8d95d744-3283-49f3-961f-12d3a23ce28e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8da432b0-8a4b-44c8-b23e-23d2943a1e65"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8dd6b88f-1b92-4764-8b8e-279740ef22ee"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8e8a9de2-57e5-472b-82d3-9f43cfebace1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8e92d01e-55b2-417f-80be-c5e1b8e20883"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("8fe615f6-dffa-43e0-9347-433d60f7fc7c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("900c2974-ec5f-42d4-87e0-e0c5c73a115f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("909c7486-b03e-4e66-8077-9b2f9635c97f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("90fa91db-bc1e-4f33-af69-4836d9ce8d3e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("914ce5b2-5c8a-4ad9-a0ce-899b190341f7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("91ee6c97-1cbe-4805-bdfd-b35f9222186b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("924edb1f-9e27-47a8-93fb-5a6c85c2b64a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("94758cfa-dd7b-4b4c-93c1-1f86d0963068"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9510b9ca-fb95-4541-af1f-0b450f6be6ce"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("954da5c1-0151-4ebd-b014-434552c14c14"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("95778f10-871e-4b27-93b6-67ff4e589fac"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("97b61200-a8e4-4352-ac6e-732fde36ff34"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("97f7f3ad-0d82-481e-a9b3-483e3fdae2a0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("98c5253a-46f0-4ec3-94a1-bf6968632a3c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("998ac1b2-5136-4755-83eb-c71892ec31e0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("99ba9f70-5bb9-4644-af6f-f6b1aacf3802"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9a0078de-b7f4-4b39-8d18-771c6bb0d348"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9a1569b9-ab09-446e-b2df-9af69d370f00"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9abc4fbb-61aa-4b51-97eb-a7eff0708491"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9b2158a0-5264-42db-8888-fff5803fec65"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9db7d900-df98-4ee1-88bb-4f742ecd57c0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9e004067-5bb2-4c20-b27e-e65cf1021ed1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("9efff7c7-83e4-4d94-bacb-760f70469321"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a1f0f25e-7997-4484-802c-a465ca071806"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a2344d21-d4ae-41ae-b3c3-016726d323fb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a2f9be43-5302-4386-a301-1198f933a2c1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a353fc69-4d0d-4d72-9fc5-a1762503af10"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a3aa87c6-a5e5-4c6c-836f-0a4c2aabfa25"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a463bed8-e2f1-4888-aa8e-0e1ec2ba7f4c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a4779b49-fb4b-4b77-9d64-119dfa7f8e1f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a4c5ebdd-f5f9-4a30-a655-da7b81644c1b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a560f74d-37ae-416a-9fc3-82076b412e3c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a56f901f-9dac-4a81-b5cf-6ccce747dea7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a5ac06d8-e0ec-4816-88c5-9de2aa39c215"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a5b55dcc-3b8b-4e29-886a-8c9d706bfc26"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a6612f91-6dae-4d2a-b0d9-b1dec4b13cef"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a682c1f6-8708-4cd1-929d-fd0a778147ec"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a769e408-c2d4-455d-8db7-85dbe1f71c8d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a77f1e7f-733a-4052-a969-9993235a6b0a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a782c998-bc3c-434d-ad1c-655416a85463"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a7a1cc78-155d-4a03-8c41-740371b76907"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a811565e-9dd3-4e66-8283-796e1f5ae3ae"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a85b6f57-acfd-4670-b729-ef504865f4b0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a86dbf89-c9c1-4c9e-b5e6-1406e18f9051"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("a9e1e6a6-b371-47bd-a747-501a911e0b7f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("aab65e45-d601-4d17-8f5c-8b2016519f88"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ab2d8b63-e54b-4241-bb40-e9b86c5a82f0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ab883eb2-df33-481e-a540-c16b6518698f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ab98fa77-587f-44ee-b3fc-c7b0816acd50"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("abda80c8-9ad1-4d0c-8482-723200384cdf"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ac073cb4-3107-4185-b5c6-5a13d6597ca4"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ac3e85bf-c470-4f70-8538-0bc69f8c9c79"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("acb7795c-792f-4f5e-9a4f-83953f929e53"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ad3c80c4-0699-44fe-8d84-547d76a117ff"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ad8ba056-510e-4b94-8916-d3fbaef9d483"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("afac17b9-bc99-40f5-a04e-cde13a908968"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b10a965a-a995-49e6-90a7-e94bb3bdc932"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b23056b9-d18e-4fe6-81b5-9798562a7925"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b2380f17-ca4b-43e4-8329-8170209a83cb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b33ca8d6-e9fa-45ff-9e6c-c900a718089c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b3e4f9f0-273d-4633-a504-1bc9a4309ff5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b3ec31db-c138-4550-a90e-158708196c3c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b4ecafd1-1829-4356-b6b2-861986c29c2a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b5a3d5b5-1322-4abf-9051-f7f5b26e71d6"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b5e92090-9beb-446d-8c5c-d943f1a10094"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b62d8c49-17b6-4543-9197-d4e7f93d72d3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b6b20700-abb0-4b72-8ca9-35e68292d285"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b72bf90e-3013-484c-a02c-4ff0bf24da0c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b79c487f-ed3b-42b0-92cf-b9cb2a6047ae"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b79d03af-c039-4a67-82e1-24fa198c8556"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b8b0e975-2f6f-4580-abcc-8a6629cb1ecb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b8c476da-4d6b-45d2-851f-00a185499710"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b9028932-c3ad-47c8-a8fa-108378fe74b6"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b90386e0-4396-4429-bc82-98b0ab903eed"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b9819a62-b240-4684-a816-cc781d2bc8d4"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("b9b1777e-64d0-4032-af0b-54450eede067"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("baa63f5d-b426-4cf3-8b80-e32f8eeb5321"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("bc07c209-7e1b-4a2d-a483-d582156afff5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("bc8ab2e1-95df-41ce-925a-5eb675258b23"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("be5cbb74-c5fd-4cb9-9864-aa31f8554612"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("bf1edf83-c2a8-4569-a1d3-2ed01f1cdb32"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("bf52e4f6-9738-48bd-8d61-a7d0e6748384"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("bf54d7a8-ebce-46da-8ae3-e5b650f51901"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c016da44-5f13-4341-934d-c0c154991aed"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c17b29e5-fd18-4e5e-8810-0f05202d6433"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c1d29cec-b38b-4f7f-9f99-dbe419b5f78e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c20f9f5d-0e3b-47cb-b343-94145105814b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c2effeab-efc3-4879-b4b3-702a3ebd2d61"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c37a5fe5-ab89-486e-a001-bdc6c8a5c889"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c4d9068b-67ce-43cb-8051-771769b853c1"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c4dbb734-ee2d-4266-a02c-4a5c14319a1e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c624e167-965c-4deb-a2c9-f2b5038853f4"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c62a4f5a-2dfa-445b-98f8-aa6bbd223896"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c6a8acfe-1738-4dce-a19a-78f4fed49a01"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c6d72436-4607-4cd6-87e5-8376d25ccc93"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c7388f65-41bd-4c7e-aa7b-87ab1f67a788"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c81e0188-cff8-40c3-b76a-cefd0d8be248"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c87d376d-7607-4b6e-81e4-289cd52a72ae"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c88a82d4-52bb-438c-82fc-228460838f1d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c8ef303f-cf6e-4134-8e2a-c935cccc157a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c9d9183e-4121-4340-a264-9e68a5b84fbb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("c9e2ef41-fddf-40bb-9d22-fb68d1d3d156"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ca45c31d-0cc3-4ff5-b2dc-333e5a94d41a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cac5502d-c6b0-4ebc-9fa9-f70f04ea201c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cbd671e7-3e4f-4cb1-9127-75d82edac9d3"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cbf0cd99-bb88-41fe-88ba-c8239dd3823a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cbfb1eeb-6e40-4a1b-afdd-3087090ce367"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cc524c54-59cb-4d01-b30f-072b55db2b46"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cd00e612-dbc2-4530-81b8-6e38ac615b1f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cd197c07-0881-4857-a58f-8b02a0267b3d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cd55e48b-514d-45de-ba89-f5e278988235"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cd7bd2ff-69f1-4091-8790-c0c9088f05ea"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cdc1eeda-432e-47ef-a1ae-898cdb13ad2a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cdd7e2d0-72ff-4860-a234-224c60a4e305"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cf23ed30-9417-47c3-82e4-ed83ef4fe029"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("cf870238-c564-4624-8402-1cd47203aa37"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d0c149fc-eb69-4be5-a492-a6141581e597"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d1645530-3955-4d3d-b87d-e64f2a92a35a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d18ec693-9d92-466f-8648-29547fe56e2c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d1b2f230-2cbb-41fc-99be-2bc8b69f7657"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d1bd0a14-9f41-4b48-84e0-496582f28af0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d2045565-d098-42ea-9da8-1a057bceb015"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d3a4836e-d09d-4f6d-8c70-af0e692aec44"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d5868211-e33f-4200-ac7a-d2e17be107ae"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d5c2cda9-c8c6-49e0-aeb2-e8f1791ce910"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d5c78913-6713-48b2-94cb-107bc97482b8"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d6395d36-8bb6-4015-94e2-296b47508e9c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d6cc9bdf-159c-4f54-9376-2118727ed5e9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("d8b6f268-dce6-4fd9-85bc-a7cf52861d36"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("da800a9b-3a44-46e1-84b3-ca38a1296e83"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("dbedf850-e37b-479d-b2f5-4f5691aa8722"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("dbffadbf-0625-40e5-90fb-93f6d7c4e733"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("dc3cbbe6-67cc-436c-9291-87f08f6e53bb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("de32755f-d89d-4e4d-bbc3-8376c4f69d4a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("de83a032-d750-4905-96b7-52fb93389d8a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("df1eba44-ae33-44d8-89c0-d364ebfe8653"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("df9ac075-8d21-4606-91a7-b2ea04c5ca89"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("dfe471c3-2e52-4580-a96b-d6dcd33d381b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e07fb8ef-9647-44d5-bc83-d6450d57767d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e0ceb5f6-42cc-4c8f-819c-fcd4524c3011"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e0db050b-4fd8-476c-b917-ac12ebf21b09"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e129baf9-0b0f-4e3b-b39b-4436ca13c2f5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e19297fa-7fe3-4e49-8829-ed5a92df80ac"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e234baf8-80a6-4a65-8e00-99987592679a"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e295e503-083e-4077-9e2a-30c1c49be37b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e2ff5983-de6d-4a79-9eb8-cea0c5d96198"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e380cc55-a296-4e66-8d1c-410798cf719b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e3b22bb4-7432-473f-bafb-113b44dd7164"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e3ed4391-ebbd-429c-acff-abc3b37c267c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e4a6653b-a3db-457f-8f3b-1aee3e2332f9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e538aa57-97d0-4ef0-801e-ebaaee5af28e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e654914c-a3a6-49bc-94cb-f5bfe23cdd65"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e6869171-7778-49a1-8b55-6057a65eb36b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e7118113-d4b4-4877-afe2-f747d6d7181e"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e7429d8f-955f-4e1d-a871-2d6a13b7055c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e7d244cb-e09c-4785-9438-436745d2839b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e8ced2f7-5e9d-43f9-8335-3ad6b7cdc777"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e9742b10-4a8e-4fb9-9d13-0e65ce914440"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("e98aa049-2f42-4dc3-87af-89943d85e2f6"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ea74cf25-3d71-4a13-bc9b-39ca0bcf440c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ea86ce25-b72f-4535-aa24-269d94d78f2c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ea8f12e6-bc21-45f1-a708-c7e285f0c21d"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("eaafc09b-eeb7-4d79-9463-55a7c31857d0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ebf71930-3d56-480b-b364-f3bac65dcf71"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ec0b8c56-de53-4303-b24a-0e70fcc809f0"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ec2989e1-f244-491b-8982-f1a1583180eb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ec3184b7-f7e3-46f9-8b6a-02bdbf0d1fcf"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ecb6fb69-e422-415b-8b5e-f95d0110e94f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("eeca379a-cc92-489b-86aa-40b7363096e5"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ef138256-676c-4f00-9cc1-de78f55cb2f2"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f03439a4-cf8f-42dc-869f-83e3e4f162eb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f1495025-25cc-48a0-a515-cf0482459a67"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f2686468-a1d6-47e0-a0e3-51e6975b2c48"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f3aafc7b-8c7c-4966-91b4-21a987fd6983"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f3ca07d3-8101-45db-ba9f-8e0b5e10e883"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f7906035-d01d-4b6d-a687-5de0d60c041b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f7d1e54a-36ee-4c45-a090-069d1b0b5d6c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f8101024-8b87-4ee3-9ef0-fd075a5aae88"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f856272a-e476-4c38-b632-3876ab83929f"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f8ce794f-fa3d-46e1-b536-67d48dab2698"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("f9aa1961-b3da-499f-b095-fdbe70d3cfd9"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("fb1f0f1d-c2eb-4050-bad4-60604811db7b"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("fbd51f4c-98ba-43e6-a071-6b1720b7ce18"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("fc16ca74-7e61-49d2-96ff-b6ba3e252add"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("fc2e0f24-ac1c-4ddc-8274-60e0262b7dbb"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("fd7c3e78-8853-427d-89a2-f2714962d6e7"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("fe35a8f0-53e6-4244-bbae-921d4a9f03ea"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("fe47cf84-02b5-435e-9d73-467a3938a31c"));

            migrationBuilder.DeleteData(
                table: "Genericos",
                keyColumn: "Id",
                keyValue: new Guid("ff9ab922-1f49-4d81-96eb-64653bcb532a"));

            migrationBuilder.InsertData(
                table: "Genericos",
                columns: new[] { "Id", "Codigo", "Nome" },
                values: new object[,]
                {
                    { new Guid("00dde46e-7dca-4d50-980a-6b8662584c38"), 323, "Rifampicina" },
                    { new Guid("00e137a4-ab96-4199-bd2b-347e859c6a6d"), 282, "Orlistate" },
                    { new Guid("012edb07-4faa-485f-a72d-f6527db857bc"), 67, "Caspofungina" },
                    { new Guid("02cbdf8b-a127-41ba-b127-51033dccadb8"), 310, "Propatilnitrato" },
                    { new Guid("033e4bc0-ac83-4ab8-80e0-b957b7a22375"), 214, "Lamivudina-Zidovudina" },
                    { new Guid("03468314-37d0-4ccc-a80b-9727b44d25ba"), 368, "Valaciclovir" },
                    { new Guid("03833667-3045-4aa6-9b2d-bb2c92a69027"), 215, "Lansoprazol" },
                    { new Guid("048ee528-ca3e-4112-b4d0-dd705515ae03"), 94, "Clonidina" },
                    { new Guid("04dcbd6c-629b-4429-b9cb-a03e38b74fac"), 257, "Cloreto de Sódio (NaCl)" },
                    { new Guid("077dc368-7a5a-4b72-b02d-130e4ae83783"), 90, "Claritromicina" },
                    { new Guid("07a0fec7-846b-4d21-a6b4-dc192073e366"), 176, "Gliclazida" },
                    { new Guid("08caa49e-edc5-4919-814b-8a443bbca99b"), 128, "Disopiramida" },
                    { new Guid("0d0cd469-cea2-43a9-bbcc-2d7a0a8d23a4"), 138, "Enalapril" },
                    { new Guid("0d692771-5825-4fca-81a1-1d7222e9178b"), 251, "Milrinona" },
                    { new Guid("0e43e1a2-e45b-4eb2-9b62-dc3495ba7290"), 353, "Ticarcilina" },
                    { new Guid("0fc7a4a4-da4f-4c01-95dd-a66e90e3236c"), 278, "Octreotide" },
                    { new Guid("113b6f52-babc-4651-b608-c744bfdff99f"), 330, "Rivastigmina" },
                    { new Guid("12b6d183-b095-460d-9d1d-1d0e327ff517"), 348, "Teicoplanina" },
                    { new Guid("134ccb7b-96de-48e9-8c13-a3b37cea966d"), 319, "Ramipril" },
                    { new Guid("13d37ed5-7409-4c89-b60d-7d8f84f0defa"), 185, "Hidroclorotiazida" },
                    { new Guid("149e066e-898c-40b8-8738-59db981d69f2"), 133, "Doxazosina" },
                    { new Guid("14e8e047-f8e8-404c-a139-d716bb344233"), 188, "Hidróxido de Alumínio" },
                    { new Guid("1678b5f0-ab26-456f-b7bf-4bcd438a330a"), 315, "Quinidina" },
                    { new Guid("1709a855-6dc3-4581-b84e-da69c014b595"), 198, "Imipenem" },
                    { new Guid("179f8083-98aa-4c6a-9cb0-a588d62c4b52"), 59, "Bisoprolol" },
                    { new Guid("17a12a86-31ea-4d98-a18c-9279f20cfcd4"), 164, "Fluoxetina" },
                    { new Guid("17bf5cb0-7792-4a69-9060-42446ac59d2c"), 166, "Fosamprenavir" },
                    { new Guid("17c89cea-8c90-4a31-98b9-e02fd64f6bf6"), 244, "Metilprednisolona" },
                    { new Guid("1a3541eb-97ba-499f-a0b8-d12d03a13b6d"), 42, "Atazanavir" },
                    { new Guid("1a8f8648-3af8-4616-9ed9-bc00c00eddd4"), 13, "Adrenalina" },
                    { new Guid("1b6c4dc6-d6eb-4302-9aec-fb4024988cd4"), 118, "Diclofenaco" },
                    { new Guid("1b9e76c7-9320-4a13-bb4f-7a40eae07cfd"), 24, "Ambroxol" },
                    { new Guid("1ba57552-723a-49bc-9e60-22040d563d7e"), 158, "Floratil" },
                    { new Guid("1bc29677-1b03-4e26-8436-402dd8b47927"), 265, "Nifepidina" },
                    { new Guid("1c10b8d8-bed8-4eb8-86cf-6803b1b4f88c"), 182, "Haloperidol" },
                    { new Guid("1c141ecc-f314-4ac0-9216-63b4b298f2ac"), 288, "Paracetamol" },
                    { new Guid("1c716e9f-0fab-4859-9a6f-f3acd2aec4f1"), 135, "Drotrecogina Alfa" },
                    { new Guid("1c8efe4f-64b3-4a8f-9b45-fa928362c44c"), 290, "Penicilina G" },
                    { new Guid("1d25a4fc-561f-429f-9b1c-69716e9545ea"), 346, "Sulfato Ferroso" },
                    { new Guid("1d37bf5f-230a-433a-95c3-3507f69579d5"), 343, "Sulfametoxazol-Trimetoprim" },
                    { new Guid("20873790-d0bc-4499-bb8a-5330c836f364"), 65, "Carbamazepina" },
                    { new Guid("209ad0ff-5ea6-405b-83d3-13488c991a81"), 350, "Terfenadina" },
                    { new Guid("218e134e-415d-4ec2-82c0-c637d082006b"), 163, "Flunitrazepam" },
                    { new Guid("225d11e7-4325-4d0b-b9b8-6f50b272eebb"), 320, "Ranitidina" },
                    { new Guid("22c1f0ee-8bbe-4c0c-a27d-698defa48315"), 127, "Dipirona" },
                    { new Guid("2319b5eb-91a3-4d67-98bc-3c2eda6d22ff"), 43, "Atenolol" },
                    { new Guid("234e8795-6e0e-4ee6-80cc-28eeebe91b35"), 303, "Pravastatina" },
                    { new Guid("240bfca6-45fc-48f2-8022-4af0694011db"), 342, "Sucralfato" },
                    { new Guid("240febea-16db-4e65-903d-68b6a52c9334"), 329, "Rivaroxabana" },
                    { new Guid("25010da4-f6ef-4b82-b639-36d6325251e1"), 211, "Labetalol" },
                    { new Guid("25da5402-4746-47e1-b93a-23e1ff435dee"), 276, "Ocitocina" },
                    { new Guid("2601dec4-6a1b-404f-87a8-ea2aa5f2d5ad"), 370, "Vancomicina" },
                    { new Guid("26d67e7f-fc56-4287-a4cb-ecc9882d3b1e"), 47, "Atropina" },
                    { new Guid("27d31d22-4be4-45cc-8cf2-f572b6e9bd6e"), 332, "Rosuvastatina" },
                    { new Guid("28d0b35b-751b-4aed-9056-bc9584088d39"), 54, "Betametasona" },
                    { new Guid("297abb8c-e1f9-429a-a6a5-8afd2c54ab45"), 28, "Amitriptilina" },
                    { new Guid("29b15bbe-375e-4006-af1d-853bbcd1a671"), 269, "Nitrendipina" },
                    { new Guid("29ea55ba-90ed-4995-8621-b6eb600e0fa9"), 172, "Gentamicina" },
                    { new Guid("2a31bad3-e46d-455b-95e8-52aa2c44838f"), 200, "Indapamida" },
                    { new Guid("2b13c2f5-3e97-4f4e-af3b-07b35381b7b4"), 80, "Cetoconazol" },
                    { new Guid("2b228948-2d3a-4dbe-8aa1-71db2f5c4e71"), 263, "Nevirapina" },
                    { new Guid("2ba6a1b4-f8e1-47c1-8bd4-9a188149342e"), 374, "Verapamil" },
                    { new Guid("2c06c80f-97c9-4328-8125-33ef8360c6ed"), 19, "Alfentanil" },
                    { new Guid("2d032842-8132-419d-8dc4-83755df8ac89"), 280, "Omeprazol" },
                    { new Guid("2db487a3-7f97-489e-94d7-a09dce192bbc"), 76, "Ceftazidima" },
                    { new Guid("2ec16bee-5306-4946-941b-1f576f8053a5"), 260, "Nebivolol" },
                    { new Guid("2eddc2cb-e9c6-40a8-91f4-e58c89947739"), 379, "Vitamina C" },
                    { new Guid("2ef2efe3-33e1-463c-8da9-79540c112fd8"), 222, "Levotiroxina" },
                    { new Guid("2f2b0330-5182-4d86-a978-cb883d867f80"), 202, "Indometacina" },
                    { new Guid("2f2e9715-1128-423f-902e-e09bd46f5fc7"), 205, "Insulina" },
                    { new Guid("2f4d5d65-d8ee-4c21-82a9-572084055957"), 96, "Cloranfenicol" },
                    { new Guid("2f4fdd7a-480c-42c2-b40a-ffeaaa7f99a1"), 62, "Bupivacaína" },
                    { new Guid("2fadf816-2ce7-4aa0-88ab-6ebb25952e69"), 364, "Trazodona" },
                    { new Guid("31b85211-c1a4-4dfb-afdd-e4d7b2a84640"), 53, "Betabloqueadores" },
                    { new Guid("3343e025-6704-4e40-b2ca-4f95f1fee38e"), 195, "Hisoscel" },
                    { new Guid("34e42a86-3867-4587-9edb-2f1a0ff21f60"), 30, "Amoxicilina-Clavulanato" },
                    { new Guid("35156e06-6c8f-430d-b921-06cbe0475df4"), 273, "Norfloxacina" },
                    { new Guid("354c54d5-8dc3-4729-85d2-222adbe79b81"), 270, "Nitroglicerina" },
                    { new Guid("35bb9f7c-10d4-478a-a713-9d09a065eaa4"), 97, "Clordiazepóxido" },
                    { new Guid("3765461d-afb6-4b55-9729-e1ea4f936a2c"), 336, "Secnidazol" },
                    { new Guid("379945cf-8621-4edb-85eb-0d5d69df1f03"), 285, "Oxigênio" },
                    { new Guid("385d5abf-bf5b-47db-a354-f4e51e7ef43d"), 254, "Moxifloxacina" },
                    { new Guid("38d4b104-a8d6-429f-92e5-e9f5f0a3bfe8"), 126, "Diosmina-Hesperidina" },
                    { new Guid("39ab9a8a-f118-4076-8c61-67337bf3900e"), 92, "Clofibrato" },
                    { new Guid("39c2aa88-1003-46c0-8a53-8ef7bd5344dc"), 125, "Dinitrato de Isossorbida" },
                    { new Guid("3a066aee-af3d-46bf-869f-7d9cbc2d5383"), 302, "Posaconazol" },
                    { new Guid("3b5a9802-87fa-472b-864d-5f176473323d"), 255, "Mupirocina" },
                    { new Guid("3c0764a2-3e02-42fd-bd80-0dfec2d3107c"), 304, "Prednisolona" },
                    { new Guid("3c1547f5-181c-4ebc-8e30-8ee6651b2426"), 151, "Fenazopiridina" },
                    { new Guid("3c43b670-64ef-44f4-a22e-04b5a845a825"), 240, "Mesalazina" },
                    { new Guid("3c74b614-2048-49ed-a91e-1bc89dcd8e8d"), 41, "Astemizol" },
                    { new Guid("3c8950cf-6cfd-4b4a-bac4-0b332057054b"), 83, "Ciclosporina" },
                    { new Guid("3cc1d159-1fe9-4584-a7ab-c1abac4b48f5"), 360, "Tipranavir" },
                    { new Guid("3ccddeae-c88a-4fec-8147-414c4abd847d"), 321, "Repaglinida" },
                    { new Guid("3dd4fb85-836d-4dd0-bdaa-4bb3be292dc5"), 337, "Sertralina" },
                    { new Guid("3e2147b8-4b03-4bc6-a6ae-b811eb3487cd"), 339, "Sinvastatina" },
                    { new Guid("3ed55110-a1b4-4567-a8c9-0c6b12224965"), 281, "Ondansetrona" },
                    { new Guid("3f8b6f98-18bb-4c30-add2-4de50bb628f1"), 203, "Inibidores da Anidrase Carbônica" },
                    { new Guid("3fdbdc36-e59d-4c62-a67d-4f2cc9549cf0"), 212, "Lactulose" },
                    { new Guid("406166fb-42ab-4e30-8586-a3dc1f81f1d5"), 167, "Furosemida" },
                    { new Guid("409cc746-dc35-42a6-9c0b-c5da57cbeaf6"), 221, "Levosimendan" },
                    { new Guid("40e78f72-408f-46f5-b906-2fad0e870dac"), 179, "Glipizida" },
                    { new Guid("4121c7e5-b021-4eaf-95f2-16eb6c0c9edc"), 264, "Nifedipina" },
                    { new Guid("417d3020-be77-43c1-967f-43739808fc19"), 169, "Ganciclovir" },
                    { new Guid("41a1ffb9-3641-418d-98d2-2495cbf158d0"), 40, "Antipsicóticos" },
                    { new Guid("41d34603-35a3-4915-a833-5f316e356dae"), 291, "Pentamidina" },
                    { new Guid("42150b44-4b55-4dca-8fcf-ff3577001f0f"), 181, "Gluconato de Cálcio" },
                    { new Guid("42256bb9-708f-4687-a709-3e2cb6cd20cb"), 60, "Bromazepam" },
                    { new Guid("434037ec-174c-428d-a9f2-3ee7673dbfed"), 283, "Oseltamivir" },
                    { new Guid("437d2137-4553-435b-9ded-6b6526ceb6e2"), 245, "Metimazol" },
                    { new Guid("437dbd03-9ebd-4f49-8ec4-9a382f3d906d"), 318, "Quinupristina-Dalfopristina" },
                    { new Guid("44db8c60-3735-44a2-8844-c67633fd2bc9"), 10, "Ácido Tranexâmico" },
                    { new Guid("45959dbc-fba5-4618-8185-156af3cf18e8"), 134, "Doxiciclina" },
                    { new Guid("461e2e0b-01f1-46ce-a9ce-56474a328dbb"), 369, "Valsartana" },
                    { new Guid("46c146ff-d8d6-4238-b8e4-8e46b99aa61a"), 44, "Atorvastatina" },
                    { new Guid("470ff2d2-6115-4c69-a481-33c2f60913b2"), 359, "Tiopental" },
                    { new Guid("47345838-9644-4198-9fb9-88b258a24627"), 70, "Cefalexina" },
                    { new Guid("485f8522-db1e-47c7-9d94-4fb890cf2872"), 77, "Ceftriaxona" },
                    { new Guid("486d1d77-53a8-43d2-9f22-bc9f884a123f"), 382, "Vitamina K" },
                    { new Guid("489a9403-5b25-41eb-aa42-bf38d9c5e87d"), 256, "N-Acetilcisteína" },
                    { new Guid("4ab40027-455a-4548-8131-384d8fc84b5c"), 23, "Amantadina" },
                    { new Guid("4b245e65-75ac-4a04-b0a6-c7557e50acad"), 366, "Trimetazidina" },
                    { new Guid("4b7a4943-550e-4668-82b4-efdfc9391574"), 168, "Gabapentina" },
                    { new Guid("4c557956-6503-4565-9430-ced2b5dec8e3"), 300, "Plasma Fresco Congelado" },
                    { new Guid("4c817f77-2394-4ff1-9e72-c2df52043497"), 298, "Piroxicam" },
                    { new Guid("4d5460e6-52a3-4853-8806-1730bee4d49c"), 110, "Darunavir" },
                    { new Guid("4d67e6ad-9c51-42cf-a598-e1572e50fd29"), 58, "Bisacodil" },
                    { new Guid("4dbd7296-e011-47e7-af33-4d2203899825"), 262, "Neostigmina" },
                    { new Guid("4e2c28b3-9d93-438c-8a7f-d90cf03e1df9"), 266, "Nimesulida" },
                    { new Guid("4e8043a6-691d-4acf-b4b2-9625d94ef6c1"), 99, "Clorpromazina" },
                    { new Guid("4e98c71a-3211-4607-831e-2b3c7159ae4c"), 9, "Ácido Nicotínico" },
                    { new Guid("502e8b0b-4488-4670-8e31-35b468de1f33"), 180, "Glucagon" },
                    { new Guid("50869480-badf-49fd-923b-56804f444311"), 297, "Pirimetamina" },
                    { new Guid("512cf409-1cb3-4ce9-975e-fe9b4083c915"), 107, "Dantrolene" },
                    { new Guid("513e1d3c-8b7a-410d-8cb8-1b091fa4ec0b"), 26, "Aminofilina" },
                    { new Guid("5171dbfc-b477-45b4-bd99-2d8b560726f5"), 174, "Glibenclamida" },
                    { new Guid("53c2da7d-8f30-4908-9390-5f682352549f"), 56, "Bicarbonato de Sódio" },
                    { new Guid("53d151bb-7042-4353-be3a-6fc96965efb4"), 324, "Rifampicina-Isoniazida" },
                    { new Guid("54d49822-e5f1-4f55-b1e6-944d7bd68855"), 153, "Fenobarbital" },
                    { new Guid("555aecbd-cb04-4b2b-8a92-de6faa0821d2"), 150, "Etoricoxibe" },
                    { new Guid("55fa9f77-e695-4f48-9e05-cdf03b2acb62"), 228, "Lopinavir/Ritonavir" },
                    { new Guid("55fbf9cb-beae-48fd-9f76-63fa6172fdaa"), 183, "Heparina" },
                    { new Guid("565087a8-c60d-43c7-8965-4ad254f645c7"), 258, "Nalbufina" },
                    { new Guid("59c3a0a7-ab2d-4ce3-a018-e071282f1e6f"), 352, "Tiazídicos" },
                    { new Guid("59effd9d-50f1-4276-a3b0-b2c39cc7f9b1"), 377, "Vitamina B12" },
                    { new Guid("5ada6ff5-cb09-4f6e-a947-a8f48dd3bb74"), 105, "Colestiramina" },
                    { new Guid("5b34aefe-efc0-4483-a176-ae647b8ae754"), 144, "Espironolactona" },
                    { new Guid("5b9a4199-7e28-4dd7-a5d7-c283885ff86a"), 187, "Hidroxicloroquina" },
                    { new Guid("5be7d632-8d5c-4015-9bd6-c40ae6a61ff9"), 271, "Nitroprussiato de Sódio" },
                    { new Guid("5d74ff44-8c86-4a19-9666-32a7d6f2db74"), 248, "Metotrexato" },
                    { new Guid("5f103c5c-5d84-4678-b6dc-670fd1303cb6"), 289, "Paroxetina" },
                    { new Guid("5f2dd86d-77e8-43ee-925e-75a361d34955"), 272, "Noradrenalina" },
                    { new Guid("5fe2ebdb-1623-4a64-8661-d4788fbf4742"), 252, "Mononitrato de Isossorbida" },
                    { new Guid("6065f891-d43a-466b-92a5-772470bed07b"), 201, "Indinavir" },
                    { new Guid("61107e04-e8f5-444d-9a45-86e88c09f484"), 235, "Manitol" },
                    { new Guid("6167a4d2-08c7-4cac-9148-e0a037035172"), 45, "Atovaquona" },
                    { new Guid("617ddc2b-1653-41bd-98c2-0497486d5b54"), 316, "Quinina" },
                    { new Guid("61b05e8e-870e-4af2-acf2-adec78c2a4b1"), 162, "Flunarizina" },
                    { new Guid("625b1a19-619d-4a6b-89ca-dd954edbd053"), 345, "Sulfato de Magnésio" },
                    { new Guid("625b9e34-6b9a-457b-b4d1-3d220ca5a518"), 117, "Diazepam" },
                    { new Guid("62d5c40d-168b-4ee1-8873-4ef6af8e5aa9"), 381, "Vitamina E" },
                    { new Guid("63e2a804-fbe2-4763-a8e7-34e4d95b71e1"), 157, "Fleet Enema" },
                    { new Guid("6594d069-5ce7-423f-b7fa-7edab7acfd68"), 5, "Aciclovir" },
                    { new Guid("65c8f3cc-5d00-4487-9f63-9a9faa53cd50"), 69, "Cefadroxil" },
                    { new Guid("665d61e3-fe8a-4ec7-9947-acce01764c5e"), 22, "Alteplase" },
                    { new Guid("667f2bd5-66aa-4706-9634-3a6c9e2cfe8b"), 293, "Pentoxifilina" },
                    { new Guid("67847e2c-c8b8-4848-985d-9b8a4c1ddf35"), 37, "Anlodipina" },
                    { new Guid("6806d8da-4630-45d0-baa5-c32f0a4ddecc"), 141, "Eritropoietina" },
                    { new Guid("680a062a-2168-461c-b50f-9ca36e5710f1"), 131, "Domperidona" },
                    { new Guid("6a97141f-565f-4fae-b62a-3b8dd94c28fd"), 61, "Bromoprida" },
                    { new Guid("6b4c7fd2-669b-4cee-a832-4c575d051116"), 301, "Polimixina B" },
                    { new Guid("6b598c6c-911b-4a73-822a-ed785b4a1442"), 155, "Fentanil" },
                    { new Guid("6b7c43f2-c53d-47b2-bfc7-870c9c91067d"), 123, "Dimenidrinato" },
                    { new Guid("6b8b6302-142a-4b35-8f72-f30a5cf47c22"), 178, "Glimepirida" },
                    { new Guid("6be30ce0-a101-4193-8e80-60dcd2b4d3f5"), 373, "Venlafaxina" },
                    { new Guid("6d9e99bf-3d26-4ac9-a6f1-51fdc8d3ea5b"), 175, "Glicerina" },
                    { new Guid("6db9d695-0a35-41b4-8b0d-b8409f12a642"), 239, "Meropenem" },
                    { new Guid("6f6f8aad-3d8c-4094-9a2f-2574b8f188e9"), 55, "Bezafibrato" },
                    { new Guid("7078930d-c1aa-4344-abc2-3d03aa7fc26e"), 8, "Ácido Folínico" },
                    { new Guid("71a7428b-0ce1-493b-b0d7-6bf15cd311be"), 223, "Lidocaína" },
                    { new Guid("72c84cf1-f626-4f44-b922-7b38565d3634"), 267, "Nimodipina" },
                    { new Guid("72d50b53-e167-4361-a800-01831a4228cd"), 375, "Verapamil (duplicado)" },
                    { new Guid("72e8d77c-e81a-495e-893b-84ddca7b1adf"), 152, "Fenitoína" },
                    { new Guid("734f55bf-b433-4430-9d98-568578b8899f"), 365, "Tricíclicos" },
                    { new Guid("7465014c-e96e-48e6-af2f-dd02fb4a5a88"), 36, "Anfotericina B" },
                    { new Guid("78cf3a28-f85a-4cb8-9773-0e5329a382df"), 4, "Acetazolamida" },
                    { new Guid("791a62dc-7a52-4777-86e2-29a170874ddd"), 32, "Ampicilina-Sulbactam" },
                    { new Guid("792eb5a7-8b45-4183-acad-345969e6f5b9"), 139, "Enoxaparina" },
                    { new Guid("7a8ccd87-c829-4f02-80e0-7f7b31a11596"), 194, "Hipoglicemiantes Orais" },
                    { new Guid("7b2bd717-0e4b-4c1f-a220-78daced29e17"), 231, "Lorazepam" },
                    { new Guid("7b409a5e-ddf3-4bc1-832f-a979f7a16e31"), 186, "Hidrocortisona" },
                    { new Guid("7b6b40e1-406d-4fb3-8a32-0e84aa0ec988"), 68, "Cefaclor" },
                    { new Guid("7bb06aa1-436c-40b1-9f80-525470fbf3a2"), 189, "Hidroxietilamido" },
                    { new Guid("7c4318c5-c54d-405c-aac4-99d3a189b760"), 354, "Ticarcilina-Clavulanato" },
                    { new Guid("7d9292a0-9c81-41cd-a96b-18de6725f93d"), 299, "Pitavastatina" },
                    { new Guid("7deb49c2-6aa8-4fee-bd7e-9c0fd0ded9da"), 361, "Tirofiban" },
                    { new Guid("7e29f47c-7e7c-4fba-87a7-6ef144e74c3a"), 380, "Vitamina D" },
                    { new Guid("7f46a7bc-7054-4274-92a2-577c979234b6"), 11, "Ácido Valpróico" },
                    { new Guid("7fb78bd9-a6fe-4595-af7c-3b76d8648919"), 160, "Fludrocortisona" },
                    { new Guid("801a2865-ef9b-41d6-9d34-3efc84010867"), 91, "Clindamicina" },
                    { new Guid("80395d45-43fc-4488-9be1-646e0bbb42f7"), 197, "Ibuprofeno" },
                    { new Guid("81195fe3-5916-4ba2-87a4-2e9683d6c735"), 104, "Colchicina" },
                    { new Guid("815470cd-f24d-4f82-a918-2ef807fb13ed"), 204, "Inibidores da Protease" },
                    { new Guid("81bab126-852c-4742-891e-8200be36b889"), 111, "Delavirdina" },
                    { new Guid("81d94704-16c5-4a04-9250-95180cacdbc9"), 66, "Carvedilol" },
                    { new Guid("81ed0482-d5d5-410a-af4b-e204ce711418"), 334, "Salbutamol" },
                    { new Guid("838132d1-09c9-44c3-bf6e-7a750ee91d4d"), 34, "Amrinona" },
                    { new Guid("847d8832-71b3-4e0c-9560-f682d364ccd7"), 225, "Lisinopril" },
                    { new Guid("85010804-d167-43a1-94ae-5c1130d7584a"), 147, "Estreptoquinase" },
                    { new Guid("85eff445-6d3a-4fcb-b59a-0cd9f2160155"), 279, "Óleo Mineral" },
                    { new Guid("86d0a589-0ad1-4ce7-889f-e6c640f2defa"), 140, "Eritromicina" },
                    { new Guid("875873db-2a0a-4285-8c20-011edddf2d93"), 193, "Hioscina-Dipirona" },
                    { new Guid("87a3f4e0-d8b5-487c-aff8-524bc8a9e5d6"), 156, "Finasterida" },
                    { new Guid("882527e2-1898-469e-ac7a-b6beba9032d2"), 102, "Codeína" },
                    { new Guid("89365476-f39b-4630-be6a-ff705a198cd7"), 367, "Troglitazona" },
                    { new Guid("896f717f-0f0d-4384-a8bb-88b60d1192e7"), 220, "Levomepromazina" },
                    { new Guid("89f42874-ff6f-47f3-94c0-6c2b512869e4"), 173, "Ginkgo Biloba" },
                    { new Guid("8a175cda-99ff-4572-9f3a-11663dd891c5"), 121, "Digoxina" },
                    { new Guid("8b761d27-bea1-40c4-bf8a-662df655796b"), 20, "Alopurinol" },
                    { new Guid("8ba7e53e-bf1b-45b4-b019-22bb723862d9"), 112, "Deslanosídeo C" },
                    { new Guid("8c4e1d97-8767-4fc5-9658-ec67faf683ab"), 52, "Benzoato de Benzila" },
                    { new Guid("8c7ee497-6947-46bf-b6a1-f84ba775660c"), 292, "Pentobarbital" },
                    { new Guid("8f716755-6ec3-45b4-8ea9-3bc3155a50f6"), 232, "Lorazepan" },
                    { new Guid("8fd2f293-fc7e-43c3-9c35-fef58ab307b5"), 75, "Cefpiroma" },
                    { new Guid("913c4aa2-e96e-4e9b-846c-fba4e7fe015e"), 16, "AINEs" },
                    { new Guid("918d3dde-e696-4960-b552-51d00bc73671"), 312, "Propofol" },
                    { new Guid("91a8d9fd-2c76-48ae-abf5-604e655bd721"), 148, "Etambutol" },
                    { new Guid("91c819e1-463f-4059-9150-5d19fb6ac98b"), 311, "Propiltiouracil" },
                    { new Guid("9207f8a4-4bf3-4640-93d3-abda298a824e"), 341, "Succinilcolina" },
                    { new Guid("9379f1ff-5eaa-4770-b0da-bbf6d5f55a6d"), 295, "Pirazinamida" },
                    { new Guid("93b68dff-ab05-4322-9ad7-dc36d752221f"), 349, "Tenoxicam" },
                    { new Guid("94af0269-4588-4dc3-a2e2-32cbd26adc69"), 129, "Diuréticos de Alça" },
                    { new Guid("94ede802-82d2-4529-b7d5-2650bfc691c6"), 115, "Dexclorfeniramina" },
                    { new Guid("951a4dad-1ee3-4ae3-99cd-05fffd3277a6"), 333, "rtPA" },
                    { new Guid("96172584-20b5-4e44-9df7-5c2d7eb4bd40"), 1, "Abacavir" },
                    { new Guid("9641df43-da3e-4caa-bcb9-b12bf76f8acd"), 247, "Metoprolol" },
                    { new Guid("970faad6-abc2-4939-a068-8890700afea8"), 119, "Didanosina" },
                    { new Guid("9767d08a-0ce4-4dd8-b095-1252c02fc454"), 177, "Glicose" },
                    { new Guid("989960a6-258f-46b4-b04f-de9ae7973db8"), 307, "Procainamida" },
                    { new Guid("989cca22-5097-4c14-a34d-95ef208dab1e"), 116, "Dexmedetomidina" },
                    { new Guid("98c03122-cbb1-40cb-a394-9a2eee3f43ea"), 87, "Ciprofloxacina" },
                    { new Guid("992c4605-fb03-45d3-a018-13f0c03987bc"), 233, "Losartana" },
                    { new Guid("9b40bae9-4d98-47e1-919f-8ee354ddcb06"), 229, "Lopinavir-Ritonavir" },
                    { new Guid("9b747b64-a27e-45ba-a5cb-95997c58a075"), 74, "Cefotaxima" },
                    { new Guid("9c6acc66-f7c9-4654-96c4-433b8299e90b"), 78, "Cefuroxima" },
                    { new Guid("9c7f7b0f-d2a9-4dc5-b599-698113534a04"), 108, "Dapsona" },
                    { new Guid("9d654410-1605-4635-907c-c4627535397c"), 15, "Água" },
                    { new Guid("9db77b6a-8ed6-4d1b-8c08-91ab1d589065"), 39, "Antiparkinsonianos" },
                    { new Guid("9ee62786-e8ab-4fb5-9efe-fab2c5776062"), 327, "Risperidona" },
                    { new Guid("9f78b5b9-d6bf-4de5-9bf7-4fc61d8cd7f5"), 14, "AGE" },
                    { new Guid("9fcfc43b-a67a-49d1-ae97-279150782611"), 274, "Nortriptilina" },
                    { new Guid("a13d89cd-7ad9-425d-8e8a-d70a8b9543ec"), 243, "Metildopa" },
                    { new Guid("a147164d-2b89-4578-ad66-da952d9eca70"), 335, "Saquinavir" },
                    { new Guid("a1a7cb80-3912-40c2-a220-b6a4b50f7e27"), 372, "Vecurônio" },
                    { new Guid("a1ae3644-62fd-4162-b497-6b3b5d86dfdb"), 137, "Efavirenz" },
                    { new Guid("a2cde737-29d8-408b-8247-5ef2786c498b"), 236, "Mebendazol" },
                    { new Guid("a333f20c-9ed3-4a72-8e52-e98be1a32e34"), 143, "Esmolol" },
                    { new Guid("a355ed09-292b-4806-945b-4bbd7d53398c"), 171, "Genfibrozil" },
                    { new Guid("a365a7d8-f02c-4981-835f-5babeaee6e45"), 296, "Piridostigmina" },
                    { new Guid("a3e48b75-e060-44a4-9416-ec21ea1ce2bf"), 72, "Cefazolina" },
                    { new Guid("a679159d-ccff-4be5-9d32-d90d983e7371"), 12, "Adenosina" },
                    { new Guid("a717e9a3-4e80-4b89-afad-96baf5727bff"), 86, "Cinarizina" },
                    { new Guid("a7c574db-fc15-4701-b9ff-5e54de6a1423"), 170, "Gatifloxacina" },
                    { new Guid("a90f5669-bc60-4bd8-b9e5-71d98402c139"), 317, "Quinolonas" },
                    { new Guid("a969afb5-f220-4684-8b2f-d61c95d9c337"), 355, "Ticlopidina" },
                    { new Guid("a9ed0655-e2a3-4351-bc52-e17813b5923c"), 84, "Cilostazol" },
                    { new Guid("a9f7fcdc-ee31-4892-9cd3-3874d2976706"), 79, "Celecoxibe" },
                    { new Guid("aa9e693e-471b-4aaa-a04a-ac64ad492ea0"), 387, "Curativo" },
                    { new Guid("ab79cdce-41de-4538-8e0d-f48939c1230f"), 338, "Sildenafil" },
                    { new Guid("aba2d5a4-9003-4e91-bc74-d10b896b5e4a"), 64, "Captopril" },
                    { new Guid("abf679d9-1950-4e03-8b08-d8e9847788dc"), 38, "Antiarritmicos" },
                    { new Guid("ad2ff03f-dbd2-44cb-a6f5-e906f487ca2b"), 237, "Mefloquina" },
                    { new Guid("ae175d1e-9fcf-4ad9-9950-5c15ae483931"), 146, "Estreptomicina" },
                    { new Guid("ae2a5011-086f-4d3e-95b1-3a4929297837"), 33, "Amprenavir" },
                    { new Guid("af19aa8a-8bf6-48e7-818e-9b25f7d7effc"), 386, "RIPE" },
                    { new Guid("af5e2bf6-8e2d-492f-8614-f78d22b28333"), 132, "Dopamina" },
                    { new Guid("afa86cda-d01d-401b-8e1a-419e94e462d5"), 216, "Levodopa" },
                    { new Guid("affbeba8-3611-4461-b5d8-d0e2a0507565"), 196, "Hypericum Perforatum" },
                    { new Guid("b01c2f80-0068-48ae-ba3f-e3d70270ec1a"), 326, "Ringer Simples" },
                    { new Guid("b1ee7493-c271-4204-a6cc-09f6706fa4d0"), 308, "Prometazina" },
                    { new Guid("b252dd50-4a57-4a08-aea7-66b7e9dc66a7"), 27, "Amiodarona" },
                    { new Guid("b29cd9b3-a561-4874-820c-e50d27257980"), 234, "Lovastatina" },
                    { new Guid("b3fd9733-74da-4f43-a96f-ef9c1014969e"), 57, "Biperideno" },
                    { new Guid("b468da86-6b8c-4225-9695-3f69326f6d15"), 165, "Fluvastatina" },
                    { new Guid("b65d720c-d21a-4318-9017-0c22699bcaaf"), 219, "Levofloxacina" },
                    { new Guid("b75ff752-9260-4c0f-9fea-00249ec31ecc"), 161, "Flumazenil" },
                    { new Guid("b76abd23-5f4e-4a95-8a67-aa4d90a31e90"), 305, "Prednisona" },
                    { new Guid("b80dea2f-cf64-44c1-87d9-ceebe7e41e11"), 238, "Meperidina" },
                    { new Guid("b86d5812-0392-456e-918c-1745bb35125a"), 246, "Metoclopramida" },
                    { new Guid("b942dc12-9c47-4da0-81d7-68f7fb636c94"), 328, "Ritonavir" },
                    { new Guid("ba390c71-b659-4920-83fe-b2c0df9e8072"), 145, "Estavudina" },
                    { new Guid("ba7886ad-c8fa-4003-9614-160dfb13572b"), 35, "Anestésicos Gerais" },
                    { new Guid("bbe471ee-2f2c-46f2-b7c4-6fdee03f83a8"), 371, "Vasopressina" },
                    { new Guid("bc179b67-443b-41b7-b7df-df89f87fa107"), 46, "Atracúrio" },
                    { new Guid("bc66e992-3312-4a0b-80e4-75aa74e9a173"), 347, "Tamarine" },
                    { new Guid("bc6e9ab7-72f1-461b-8277-579e2035c7ee"), 7, "Ácido Fólico" },
                    { new Guid("bc84b704-1802-45f8-a5b0-638f28e92efc"), 383, "Voriconazol" },
                    { new Guid("bdb6e931-9a5b-47ac-bca3-cc8bbf94c387"), 224, "Linezolida" },
                    { new Guid("bdf89ce8-b594-4119-84d0-9bcf55af8310"), 363, "Tramadol" },
                    { new Guid("bea17057-0ccc-43d0-ac1d-995d764c284e"), 227, "Loperamida" },
                    { new Guid("bfaf01ad-f4ab-43bb-9e67-5e70b22a64dc"), 210, "Cetamina" },
                    { new Guid("c2974317-b04c-4e46-90be-99b6ac4df663"), 230, "Loratadina" },
                    { new Guid("c2a16cd9-7c1e-4ad4-9a8b-2889df6dea6e"), 124, "Dimeticona" },
                    { new Guid("c3646547-2d8d-44f0-a65b-b40b3b022b49"), 226, "Lítio" },
                    { new Guid("c393c689-37ca-449c-bcb6-bd79b70a0762"), 275, "Nutrição Parenteral Total" },
                    { new Guid("c4c0351a-6d84-4fbc-844b-7da595cb30ae"), 184, "Hidralazina" },
                    { new Guid("c4c20e0b-f5e3-4634-860e-795b501ceb52"), 95, "Clopidogrel" },
                    { new Guid("c603c9de-a691-4c1e-875e-16bff8257797"), 191, "Hioscina" },
                    { new Guid("c77e73a8-480b-4ba7-b5fe-b3699e512fe7"), 213, "Lamivudina" },
                    { new Guid("c7dd27a0-9f2d-4f61-acf4-1824e5ef3841"), 159, "Fluconazol" },
                    { new Guid("c919e783-43b0-48c3-ae0f-2808d6ce8712"), 207, "Itraconazol" },
                    { new Guid("c9ca8720-1489-4c42-acc1-1576def4c268"), 103, "Codergocrina" },
                    { new Guid("c9d993c1-7e2d-4135-8c27-644b13748faf"), 199, "Imipramina" },
                    { new Guid("cc9a9c49-55b2-402e-a33a-ddca8d10d599"), 89, "Citalopram" },
                    { new Guid("cdee9eb1-a4b6-49ac-9d80-6109f92e0643"), 331, "Rosiglitazona" },
                    { new Guid("ce64dd8c-e945-4bf0-a44d-70926cf62ed2"), 136, "Ebastina" },
                    { new Guid("cf5a8f38-8f0d-4ebc-aad0-213d70de2537"), 18, "Albumina" },
                    { new Guid("cf87fdc0-2cfb-4236-9928-67d628615d70"), 63, "Buspirona" },
                    { new Guid("cf8c3495-cd16-4ce1-9256-807a38c97ffc"), 6, "Ácido Acetilsalicílico" },
                    { new Guid("d02e9217-9f33-4595-ae11-570370a41afa"), 73, "Cefepima" },
                    { new Guid("d05c76ed-ca22-4e09-b4e2-666432f326e9"), 192, "Hioscina Composta" },
                    { new Guid("d0819880-e46c-4ace-8618-a39c099359d4"), 85, "Cimetidina" },
                    { new Guid("d0b4705d-59eb-4960-809f-6791bd63e4da"), 25, "Amicacina" },
                    { new Guid("d0be8d33-98e3-49a8-b991-87da23aa93e0"), 286, "Pancurônio" },
                    { new Guid("d1782c39-8499-448e-b9db-79ee69fd8e4a"), 48, "Azitromicina" },
                    { new Guid("d185adf0-ba46-490d-bcab-56b9bfb60f12"), 325, "Ringer Lactato" },
                    { new Guid("d2625168-09cc-4044-9708-692db90ab7ea"), 261, "Nelfinavir" },
                    { new Guid("d2d6b2c2-2139-4483-8a88-85ef5070108c"), 29, "Amoxicilina" },
                    { new Guid("d308135e-e4e6-496c-ae97-f564e92f8111"), 154, "Fenotiazinas" },
                    { new Guid("d39673ad-a822-4a1c-9493-2d92521eebb4"), 114, "Dexametasona" },
                    { new Guid("d3ad3d46-3728-413a-84b4-d9f379b9e594"), 322, "Rifabutina" },
                    { new Guid("d487a11b-6357-45ce-b941-01ca28e5b048"), 113, "Desmopressina" },
                    { new Guid("d5346b45-29da-4809-bebe-8287fc81700d"), 378, "Vitamina B6" },
                    { new Guid("d5991a89-7510-405d-8b27-1a6b94291243"), 249, "Metronidazol" },
                    { new Guid("d6ba393f-42dc-4434-895d-36d2ef8d3348"), 51, "Bamifilina" },
                    { new Guid("d759c9f7-cdad-4d1b-81c4-63e1b066af38"), 351, "Tiabendazol" },
                    { new Guid("d7a7c203-cea9-48c4-981a-1080dc71c542"), 2, "Abciximab" },
                    { new Guid("d8eccbdf-3f4b-4d70-b141-8ce7822ead7a"), 120, "Dieta" },
                    { new Guid("d9396699-a956-4e40-8446-2d5ac91407c3"), 294, "Piperacilina-Tazobactam" },
                    { new Guid("d9b7b2e8-1b74-4ffc-986b-af74e7741d0d"), 384, "Varfarina" },
                    { new Guid("da0de704-150a-4005-a63d-8e3bf26b2447"), 93, "Clonazepam" },
                    { new Guid("da230520-62ae-4656-a823-00dbef8423d9"), 314, "Protamina" },
                    { new Guid("dab885f3-fff7-4aff-91a9-497b11600a50"), 88, "Cisaprida" },
                    { new Guid("dbfdd3f6-41b0-4419-ba76-7ce90a586bee"), 340, "Sotalol" },
                    { new Guid("dcbc7393-4acd-4f11-a023-bca7c3b0a3f5"), 242, "Metformina" },
                    { new Guid("dde0987b-5580-417c-97d6-5b0a344e057a"), 109, "Daptomicina" },
                    { new Guid("de4f3328-b304-49ba-b04e-70d945f67e04"), 17, "Albendazol" },
                    { new Guid("e174a85a-f7d2-4ea6-91a1-9ecae9671580"), 362, "Tobramicina" },
                    { new Guid("e1f1030d-9954-4abd-858f-8fcb7b1f6afb"), 82, "Cetorolaco" },
                    { new Guid("e1fbece6-485b-4be4-bde9-9448ade658d0"), 208, "Ivermectina" },
                    { new Guid("e205c377-29ec-4c6a-9b9e-fd46d7cb971e"), 31, "Ampicilina" },
                    { new Guid("e28a8fc9-8428-4712-b9ea-b59cd5f2fbfe"), 313, "Propranolol" },
                    { new Guid("e3897a36-8ae1-4067-bc75-c021de605614"), 50, "Baclofeno" },
                    { new Guid("e4b12e13-9e9a-4d68-914e-6e9791b028e9"), 284, "Oxacilina" },
                    { new Guid("e53dd49f-d90f-47fb-aeec-9ddc01eb0d48"), 209, "Cloreto de Potássio (KCl)" },
                    { new Guid("e5f35fff-7cfe-4a7b-bcb8-10c47dbc7dba"), 49, "Aztreonam" },
                    { new Guid("e6519bc1-f299-4a31-a401-316957de1951"), 268, "Nistatina" },
                    { new Guid("e7f8a7aa-7513-496e-bfd2-1e3be32269a8"), 71, "Cefalotina" },
                    { new Guid("e8fcc306-46da-4a4f-b4db-9ad0e022f62d"), 259, "Naloxona" },
                    { new Guid("e8fe0ea0-153d-417e-a0f0-28209562a2f6"), 306, "Primidona" },
                    { new Guid("e9301a47-bc91-4d39-9d3c-a2312379b540"), 277, "Octreotida" },
                    { new Guid("e94ff30b-8f6d-4791-91bc-c903d8915af2"), 21, "Alprazolam" },
                    { new Guid("e99f3032-3a35-4265-996f-112536c26009"), 309, "Propafenona" },
                    { new Guid("eb1999d2-7ce4-4875-af53-780e13c16321"), 3, "Acarbose" },
                    { new Guid("ece82e1f-0b06-4dde-935e-e2b54c72287c"), 98, "Cloroquina" },
                    { new Guid("ed7f6e3a-f39d-492e-918d-8307602d593e"), 356, "Tigeciclina" },
                    { new Guid("ee3d723f-6912-422b-bbeb-8eac60389c78"), 357, "Timolol" },
                    { new Guid("ee69ca03-c22c-4e57-8e34-c7e60d0b888e"), 190, "Hidroxizina" },
                    { new Guid("ef0aeee4-2661-4497-b77f-66d434d850d8"), 218, "Levodopa-Carbidopa (duplicado)" },
                    { new Guid("efc256a4-d6e9-47f7-810b-a7d1a009d187"), 130, "Dobutamina" },
                    { new Guid("f02b7448-c1ee-455c-8164-ab79782882a7"), 81, "Cetoprofeno" },
                    { new Guid("f0c4b941-a8c5-45b9-bc81-3c697184583c"), 106, "Complexo B" },
                    { new Guid("f42f7748-3436-4720-92ab-67167ee7041a"), 241, "Metadona" },
                    { new Guid("f50bf03f-e976-4c4c-8936-a6780774867b"), 376, "Vitamina B1" },
                    { new Guid("f514c631-8d62-4a4c-bf2a-40069b2a60ce"), 149, "Etionamida" },
                    { new Guid("f67c12b2-d7ff-453f-8945-8b2156c9cb28"), 385, "Zidovudina" },
                    { new Guid("f7f8ff7b-df81-4932-bc3a-4824e7c253da"), 142, "Ertapenem" },
                    { new Guid("f8289f62-f50d-4e88-be96-23a11a739df2"), 101, "Clortalidona" },
                    { new Guid("f8e1a0de-db73-4b4d-b690-6840b7c286bb"), 122, "Diltiazem" },
                    { new Guid("f9a8c160-c129-408f-951a-2ff7732f6d0a"), 100, "Clorpropamida" },
                    { new Guid("fb409cb3-b0ee-4e98-9351-cedab7bcabcc"), 253, "Morfina" },
                    { new Guid("fb9735b0-f171-4d3c-ac78-f66ddcb34efb"), 206, "Isoniazida" },
                    { new Guid("fcf4b836-0097-400c-b02d-968bcf54ff4a"), 217, "Levodopa-Carbidopa" },
                    { new Guid("fd890541-2ff4-473f-a6a8-fdb22a78a193"), 287, "Pantoprazol" },
                    { new Guid("fd96d3f3-7f60-4b32-928d-1eed487e2d0a"), 358, "Tinidazol" },
                    { new Guid("ffa62914-8392-4fea-8fc1-f89bf24c35c7"), 344, "Sulfassalazina" },
                    { new Guid("ffcd4649-ec93-477f-8d81-3d8661bc79be"), 250, "Midazolam" }
                });
        }
    }
}
