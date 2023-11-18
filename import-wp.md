```plaintext
jekyll import wordpress --dbname DB --socket SOCKET --user USER --password PW --host HOST --port PORT --table_prefix PREFIX --site_prefix PREFIX --clean_entities --comments --categories --tags --more_excerpt --more_anchor --status STATUS,STATUS2
```

```plaintext
jekyll import wordpress --dbname daraoladapo_com --user daraoladapo_com --password Sn2QizP5y2cm2V6R2tZ8x5DP --table_prefix blog0_ --host daraoladapo.com.mysql.service.one.com --comments --categories --tags --more_excerpt --more_anchor --status publish,draft
```

```plaintext
sudo gem install hpricot open_uri_redirections jekyll-import
```

```plaintext
ruby -r rubygems -e 'require "jekyll-import";JekyllImport::Importers::WordpressDotCom.run({"source" => "daraoladapo.WordPress.2023-11-17.xml","no_fetch_images" => false, "assets_folder" => "assets" })'
```

```plaintext
jekyll import rss --source "https://blog.daraoladapo.com/feed/" --target "./_posts" --assets_folder "./blog-assets"

gem install gemName -v gemVersion
```
