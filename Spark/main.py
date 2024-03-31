from pyspark.sql import SparkSession

spark = SparkSession.builder.appName("Product_Category_Relationships").getOrCreate()

products_data = [
    (1,"Product 1"),
    (2,"Product 2"),
    (3,"Product 3")
]

categories_data = [
    (1, "Category 1"),
    (2, "Category 2"),
    (3, "Category 3")
]

relationships_data = [
    (1,1),
    (2,1),
    (3,2)
]

product_df = spark.createDataFrame(products_data,["product_id", "product_name"])
categories_df = spark.createDataFrame(categories_data,["category_id","category_name"])
relationships_df = spark.createDataFrame(relationships_data,["product_id","category_id"])

product_categories_t = product_df.join(relationships_df,"product_id") \
                        .join(categories_df,"category_id") \
                        .select("product_name","category_name")

product_categories_f = product_df.join(relationships_df,"product_id","left_anti") \
                        .select("product_name")

print("Продукт - категория: ")
product_categories_t.show()

print("Продукты бещ категории")
product_categories_f.show()
