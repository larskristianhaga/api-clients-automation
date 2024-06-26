from asyncio import run

from algoliasearch.ingestion import IngestionClient, __version__


async def main():
    print("IngestionClient version", __version__)

    client = IngestionClient("FOO", "BAR")

    print("client initialized", client)

    try:
        response = await client.get_sources()

        print(response)
    finally:
        await client.close()

        print("client closed", client)


run(main())
