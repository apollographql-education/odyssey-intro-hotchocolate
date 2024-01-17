namespace Odyssey.Liftoff;

public class AddItemsToPlaylistInput
{
    [ID]
    [GraphQLDescription("The ID of the playlist where tracks will be added.")]
    public string PlaylistId { get; set; }

    [GraphQLDescription(
        "A comma-separated list of Spotify URIs to add, can be track or episode URIs."
    )]
    public List<string> Uris { get; set; }

    public AddItemsToPlaylistInput(string playlistId, List<string> uris)
    {
        PlaylistId = playlistId;
        Uris = uris;
    }
}
