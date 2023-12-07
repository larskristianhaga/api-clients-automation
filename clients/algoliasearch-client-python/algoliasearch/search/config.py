from os import environ
from typing import Optional

from algoliasearch.http.hosts import CallType, Host, HostsCollection
from algoliasearch.http.user_agent import UserAgent


class Config:
    def __init__(
        self,
        app_id: Optional[str] = None,
        api_key: Optional[str] = None,
    ) -> None:
        app_id = environ.get("ALGOLIA_APP_ID") if app_id is None else app_id

        assert app_id, "`app_id` is missing."

        api_key = environ.get("ALGOLIA_API_KEY") if api_key is None else api_key

        assert api_key, "`api_key` is missing."

        self.app_id = str(app_id)
        self.api_key = str(api_key)

        # In milliseconds
        self.read_timeout = 5000
        self.write_timeout = 30000
        self.connect_timeout = 2000

        # In microseconds - this parameter is used for the `wait` helper
        # methods
        self.wait_task_time_before_retry = 100000

        self.headers = {
            "X-Algolia-Application-Id": app_id,
            "X-Algolia-API-Key": api_key,
            "User-Agent": UserAgent.get(),
            "Content-Type": "application/json",
        }

        self.proxies = {
            "http": environ.get("HTTP_PROXY"),
            "https": environ.get("HTTPS_PROXY"),
        }
        if self.proxies["http"] is None:
            del self.proxies["http"]
        if self.proxies["https"] is None:
            del self.proxies["https"]

        self.hosts = HostsCollection(
            [
                Host("{}-dsn.algolia.net".format(self.app_id), 10, CallType.READ),
                Host("{}.algolia.net".format(self.app_id), 10, CallType.WRITE),
                Host("{}-1.algolianet.com".format(self.app_id)),
                Host("{}-2.algolianet.com".format(self.app_id)),
                Host("{}-3.algolianet.com".format(self.app_id)),
            ]
        )