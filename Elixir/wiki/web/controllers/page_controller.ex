defmodule Wiki.PageController do
  use Wiki.Web, :controller

  def index(conn, _params) do
    pages = Repo.all(Wiki.Page)
    render conn, "index.html", pages: pages
  end

#def show(conn, params) do
#  page = Repo.get_by!(Wiki.Page, title: params["id"])
#  # render show here and pass page
#end
#===> das nächste Beispiel nutzt Pattern-Matching. Filtert so nur den genutzten Param aus params!

  def show(conn, %{"id" => id}) do
    page = Repo.get_by!(Wiki.Page, title: id)
    render conn, "show.html", page: page
  end
end
