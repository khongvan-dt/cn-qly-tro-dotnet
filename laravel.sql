USE db_laravel;
GO
// trang giới thiệu
CREATE TABLE about (
id INT PRIMARY KEY NOT NULL,
menu_id varchar(255)NULL,
name varchar(255)NULL,
image text NULL,
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE about_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
data_id int NOT NULL,
languages_id int NOT NULL,
content varchar(255),
description varchar(255),
meta_title varchar(255),
meta_description varchar(255),
meta_keyword varchar(255),
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

-- CREATE TABLE address (
--  id INT PRIMARY KEY NOT NULL,
-- name varchar(255)NULL,
-- menu_id varchar(255)NULL,
-- images varchar(255)NULL,
-- hotline varchar(255)NULL,
-- code varchar(255),
-- other varchar(255),
-- parent_id int,
-- sort_order int,
-- create_by int,
-- created_at DATETIME NULL,
-- updated_at DATETIME NULL
-- )

-- CREATE TABLE address_data (
--  id INT PRIMARY KEY NOT NULL,
-- name_data varchar(255)NULL,
-- data_id varchar(255)NULL,
-- languages_id varchar(255)NULL,
-- description varchar(255),
-- content varchar(255),
-- parent_id int,
-- sort_order int,
-- created_at DATETIME NULL,
-- updated_at DATETIME NULL
-- )

-- CREATE TABLE admin_users (
--  id INT PRIMARY KEY NOT NULL,
-- username varchar(255) NOT NULL,
-- password varchar(255) NOT NULL,
-- name varchar(255) NOT NULL,
-- code varchar(255) NOT NULL,
-- email varchar(255)NULL,
-- chi_nhanh_id int NULL,
-- status_admin_user_id int NULL,
-- user_permission_id int NULL,
-- email_verified_at DATETIME NULL,
-- create_by int,
-- permission_group_id int NULL,
-- parent_id int,
-- sort_order int,
-- remember_token varchar(1)NULL,
-- created_at DATETIME NULL,
-- updated_at DATETIME NULL
-- )


CREATE TABLE block (
 id INT PRIMARY KEY NOT NULL,
name varchar(255)NULL,
block_type_id varchar(255)NULL,
image varchar(255)NULL,
images varchar(255),
parent_id int,
block_info_id int,
sort_order int,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE block_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
data_id varchar(255)NULL,
languages_id varchar(255)NULL,
description varchar(255),
content varchar(255),
created_at DATETIME NULL,
updated_at DATETIME NULL
)


CREATE TABLE block_images (
 id INT PRIMARY KEY NOT NULL,
name varchar(255)NULL,
image varchar(255)NULL,
block_id varchar(255),
position varchar(255),
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE block_info (
 id INT PRIMARY KEY NOT NULL,
name varchar(255)NULL,
image varchar(255),
parent_id int,
sort_order int,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE block_info_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
data_id varchar(255)NULL,
languages_id varchar(255)NULL,
description varchar(255),
content varchar(255),
parent_id int,
sort_order int,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE block_item (
 id INT PRIMARY KEY NOT NULL,
name varchar(255)NULL,
block_id varchar(255)NULL,
position varchar(255)NULL,
title varchar(255),
description varchar(255),
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)


CREATE TABLE categories (
id INT PRIMARY KEY NOT NULL,
name VARCHAR(255) NULL,
image TEXT NULL,
is_front VARCHAR(255),
is_active INT,
parent_id INT,
sort_order INT,
create_by INT,
is_recycle_bin INT,
created_at DATETIME NULL,
updated_at DATETIME NULL
);

CREATE TABLE categorys_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
languages_id int NULL,
data_id int NULL,
description varchar(255),
content varchar(255),
meta_title varchar(255)NULL,
meta_description varchar(255),
meta_keyword varchar(255),
parent_id int,
sort_order int,
create_by int,
is_recycle_bin int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE colors (
 id INT PRIMARY KEY NOT NULL,
name varchar(255),
code varchar(255),
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE colors_data (
id INT PRIMARY KEY NOT NULL,
name_data TEXT NULL,
data_id TEXT NULL,
languages_id TEXT NULL,
parent_id INT NOT NULL,
sort_order INT NOT NULL,
create_by INT,
created_at DATETIME NULL,
updated_at DATETIME NULL
);


CREATE TABLE discount_code (
 id INT PRIMARY KEY NOT NULL,
name varchar(255)NULL,
code varchar(255)NULL,
image varchar(255)NULL,
time_start date NULL,
time_end date NULL,
create_by int,
sort_order int,
parent_id int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE discount_code_data (
id INT PRIMARY KEY NOT NULL,
name_data VARCHAR(255) NULL,
data_id INT NULL,
languages_id INT NULL,
description TEXT NULL,
content NVARCHAR(MAX) NULL,
create_by INT,
sort_order INT,
parent_id INT,
created_at DATETIME NULL,
updated_at DATETIME NULL
);



-- CREATE TABLE flash_sale (
--  id INT PRIMARY KEY NOT NULL,
-- name varchar(255)NULL,
-- time varchar(255)NULL,
-- date_start varchar(255)NULL,
-- date_end varchar(255)NULL,
-- create_by int,
-- sort_order int,
-- parent_id int,
-- created_at DATETIME NULL,
-- updated_at DATETIME NULL
-- )

CREATE TABLE images (
 id INT PRIMARY KEY NOT NULL,
name varchar(255)NULL,
type varchar(255)NULL,
image varchar(255),
images varchar(255),
link varchar(255),
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE images_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
data_id varchar(255)NULL,
languages_id varchar(255),
description varchar(255),
content varchar(255),
meta_keyword varchar(255),
meta_description varchar(255),
sort_order varchar(255),
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE images_type (
 id INT PRIMARY KEY NOT NULL,
name varchar(255)NULL,
type varchar(255)NULL,
parent_id int,
sort_order int,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE link_footer (
id INT PRIMARY KEY NOT NULL,
name varchar(255),
link varchar(255),
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int NOT NULL,
created_at DATETIME NULL,
updated_at DATETIME NULL
)
-- tiếp theo

CREATE TABLE menus (
id INT PRIMARY KEY NOT NULL,
name VARCHAR(255) NULL,
image TEXT NULL,
display_name VARCHAR(255) NULL,
display_type VARCHAR(255) NULL,
position INT,
meta_title VARCHAR(255) NULL,
parent_id INT,
sort_order INT,
type_sub_menu VARCHAR(255),
is_front VARCHAR(255),
current_link TEXT NULL,
is_register VARCHAR(255),
icon VARCHAR(255),
is_active INT,
create_by INT,
is_recycle_bin INT,
created_at DATETIME NULL,
updated_at DATETIME NULL
);


CREATE TABLE menus_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
languages_id int NULL,
data_id int NULL,
description varchar(255),
content varchar(255),
meta_title varchar(255)NULL,
meta_description varchar(255),
meta_keyword varchar(255),
parent_id int,
sort_order int,
create_by int,
is_recycle_bin int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)
CREATE TABLE news (
id INT PRIMARY KEY NOT NULL,
name VARCHAR(255) NULL,
menu_id INT NULL,
tags_id TEXT NULL,
sort_order INT NULL,
image TEXT NULL,
is_active INT,
create_date DATETIME NULL,
is_translate INT,
is_front INT,
views INT,
tags TEXT NULL,
parent_id INT,
create_by INT,
is_recycle_bin INT,
created_at DATETIME NULL,
updated_at DATETIME NULL
);

CREATE TABLE news_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
languages_id int NULL,
data_id int NULL,
description varchar(255),
content varchar(255),
meta_title varchar(255),
meta_keyword varchar(255),
meta_description varchar(255),
parent_id int,
create_by int,
is_recycle_bin int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE orders (
id INT PRIMARY KEY NOT NULL,
name VARCHAR(255) NULL,
user_id INT NULL,
product_id VARCHAR(255) NULL,
bds_id INT NULL,
price INT NULL,
promo_price INT NULL,
note TEXT NULL,
sort_order INT NULL,
quantity INT NULL,
is_payment INT,
invoice INT,
phone VARCHAR(255) NULL,
email VARCHAR(255) NULL,
is_view INT NULL,
create_by INT,
created_at DATETIME NULL,
updated_at DATETIME NULL
);



CREATE TABLE products (
id INT PRIMARY KEY NOT NULL,
name VARCHAR(255) NULL,
count INT NULL,
menu_id INT NULL,
category_id INT NULL,
category_ids TEXT NULL,
supplier_id INT NULL,
product_color_ids TEXT NULL,
product_size_ids TEXT NULL,
product_setting_id INT NULL,
product_setting_ids TEXT NULL,
product_info_id INT NULL,
product_info_ids TEXT NULL,
price INT NULL,
promo_price INT NULL,
taxrates INT NULL,
tags_id TEXT NULL,
images TEXT NULL,
video TEXT NULL,
note_seo TEXT NULL,
create_date DATETIME NULL,
sort_order INT NULL,
is_active INT NULL,
is_translate INT NULL,
views INT NULL,
is_front INT NULL,
is_hot INT NULL,
parent_id INT NULL,
create_by INT NULL,
is_recycle_bin INT NULL,
created_at DATETIME NULL,
updated_at DATETIME NULL
);

CREATE TABLE products_data (
 id INT PRIMARY KEY NOT NULL,
name_data varchar(255)NULL,
languages_id int NULL,
data_id int NULL,
description varchar(255),
content varchar(255),
meta_title varchar(255),
meta_keyword varchar(255),
meta_description varchar(255),
content_promo varchar(255),
parent_id int,
create_by int,
is_recycle_bin int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE product_colors (
 id INT PRIMARY KEY NOT NULL,
name int NULL,
price_up varchar(255),
count varchar(255),
image varchar(255),
images varchar(255),
products_id int NULL,
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)
CREATE TABLE product_size (
 id INT PRIMARY KEY NOT NULL,
name int NULL,
price_up varchar(255),
count varchar(255),
products_id int NULL,
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)


CREATE TABLE size (
 id INT PRIMARY KEY NOT NULL,
products_id int NULL,
name varchar(255),
parent_id int NOT NULL,
sort_order int NOT NULL,
create_by int,
created_at DATETIME NULL,
updated_at DATETIME NULL
)

CREATE TABLE size_data (
id INT PRIMARY KEY NOT NULL,
name_data TEXT NULL,
data_id TEXT NULL,
languages_id TEXT NULL,
parent_id INT NOT NULL,
sort_order INT NOT NULL,
create_by INT,
created_at DATETIME NULL,
updated_at DATETIME NULL
);


CREATE TABLE supplier (
    id INT PRIMARY KEY NOT NULL,
    name TEXT NULL,
    logo TEXT NULL,
    website TEXT NULL,
    phone TEXT NULL,
    address TEXT NULL,
    link TEXT NULL,
    parent_id INT NOT NULL,
    sort_order INT NOT NULL,
    create_by INT,
    created_at DATETIME NULL,
    updated_at DATETIME NULL
);


CREATE TABLE users (
    id INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NULL,
    username VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    phone VARCHAR(255) NULL,
    image VARCHAR(255) NULL,
    gender VARCHAR(255) NULL,
    birthday VARCHAR(255) NULL,
    address VARCHAR(255) NULL,
    email_verified_at DATETIME NULL,
    [password] VARCHAR(255) NOT NULL,
    sort_order INT NULL,
    create_by INT NULL,
    remember_token VARCHAR(1) NULL,
    created_at DATETIME NULL,
    updated_at DATETIME NULL
);


-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng web_config
--
---ok

CREATE TABLE web_config (
    id INT PRIMARY KEY NOT NULL,
    data_id INT NULL,
    [name] TEXT NULL,
    currency VARCHAR(255) NULL,
    currency_name VARCHAR(255) NULL,
    logo TEXT NULL,
    website TEXT NULL,
    code TEXT NULL,
    gg_map TEXT NULL,
    gg_analytic TEXT NULL,
    email VARCHAR(255) NULL,
    phone VARCHAR(255) NULL,
    zalo TEXT NULL,
    facebook_id TEXT NULL,
    pinterest TEXT NULL,
    youtube TEXT NULL,
    dribbble TEXT NULL,
    whats_app TEXT NULL,
    tiktok TEXT NULL,
    telegram TEXT NULL,
    [google] TEXT NULL,
    twitter TEXT NULL,
    shopee TEXT NULL,
    tiki TEXT NULL,
    lazada TEXT NULL,
    sendo TEXT NULL,
    instagram TEXT NULL,
    reddit TEXT NULL,
    linkedin TEXT NULL,
    google_translate_api_key TEXT NULL,
    layout VARCHAR(255) NULL,
    other_config TEXT NULL,
    meta_title TEXT NULL,
    meta_keyword TEXT NULL,
    meta_description TEXT NULL,
    create_by INT NULL,
    created_at DATETIME NULL,
    updated_at DATETIME NULL
);

CREATE TABLE web_config_data (
    id INT PRIMARY KEY NOT NULL,
    name_data TEXT NULL,
    data_id TEXT NULL,
    languages_id TEXT NULL,
    title TEXT NULL,
    description TEXT NULL,
    meta_title TEXT NULL,
    meta_keyword TEXT NULL,
    meta_description TEXT NULL,
    slogan TEXT NULL,
    footer TEXT NULL,
    address TEXT NULL,
    create_by INT NULL,
    sort_order INT NULL,
    parent_id INT NULL,
    created_at DATETIME NULL,
    updated_at DATETIME NULL
);



